using KlonsChatApiServer.Services;
using KlonsChatDb.Models;
using KlonsChatDto.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Logging;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Net;
using System.Text;
using System.Threading.RateLimiting;
using System.Threading.Tasks;

namespace KlonsChatApiServer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var connectionString =
                builder.Configuration.GetConnectionString("ChatConnection") ??
                    throw new InvalidOperationException("Connection string 'ChatConnection' not found.");

            DbOps.AdminGuid = builder.Configuration.GetRequiredSection("Admin:AdminId").Value;
            UserManager.TokenConfig = builder.Configuration.GetRequiredSection("JwtConfig").Get<UserManager.JwtConfig>();
            UserManager.RateLimiter = builder.Configuration.GetRequiredSection("RateLimiter").Get<UserManager.RateLimiterConfig>();


            builder.Services.AddDbContext<KlonsqDbContext>(options =>
            {
                options.UseSqlite(connectionString);
                //options.ConfigureWarnings(w => w.Throw(RelationalEventId.MultipleCollectionIncludeWarning));
            });

            builder.Services.AddScoped<DbOps>();

            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowAll", builder =>
                {
                    builder.AllowAnyHeader()
                        .AllowAnyMethod()
                        .AllowAnyOrigin();
                });

                options.AddPolicy("Restricted", builder =>
                {
                    builder.AllowAnyHeader()
                        .WithMethods("GET", "POST", "PUT", "DELETE")
                        .WithOrigins("http://localhost", "https://localhost", "https://zbks.eu")
                        .AllowCredentials();
                });
            });

            builder.Services.AddRateLimiter(options => {
                options.RejectionStatusCode = (int)HttpStatusCode.TooManyRequests;
                options.OnRejected = async (context, token) =>
                {
                    await context.HttpContext.Response.WriteAsync(
                        "Too many requests.Please try again later.");
                };
                options.GlobalLimiter = PartitionedRateLimiter.Create<HttpContext, string>(httpContext =>
                    RateLimitPartition.GetFixedWindowLimiter(
                        partitionKey: httpContext.Connection.RemoteIpAddress.ToString(),
                        factory: _ => new FixedWindowRateLimiterOptions
                        {
                            QueueLimit = UserManager.RateLimiter.QueueLimit,
                            PermitLimit = UserManager.RateLimiter.PermitLimit,
                            Window = TimeSpan.FromSeconds(UserManager.RateLimiter.Window)
                        }));
            });


            builder.Services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options =>
            {
                options.SaveToken = true;
                options.RequireHttpsMetadata = false;
                options.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidAudience = UserManager.TokenConfig.Audience,
                    ValidIssuer = UserManager.TokenConfig.Issuer,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(UserManager.TokenConfig.Secret))
                };
                // Hook the SignalR event to check for the token in the query string
                options.Events = new JwtBearerEvents
                {
                    OnMessageReceived = context =>
                    {
                        var accessToken = context.Request.Query["access_token"];
                        var path = context.HttpContext.Request.Path;
                        if (!string.IsNullOrEmpty(accessToken) && path.StartsWithSegments("/signalhub"))
                        {
                            context.Token = accessToken;
                        }
                        return Task.CompletedTask;
                    },
                    OnTokenValidated = context =>
                    {
                        return Task.CompletedTask;
                    },
                    OnAuthenticationFailed = context =>
                    {

                        return Task.CompletedTask;
                    },

                };
            });

            IdentityModelEventSource.ShowPII = true;
            IdentityModelEventSource.LogCompleteSecurityArtifact = true;

            builder.Services.AddAuthorization();
            builder.Services.AddSignalR();

            var app = builder.Build();

            app.UseCors("Restricted");
            if (UserManager.RateLimiter.Enabled)
                app.UseRateLimiter();
            app.UseAuthorization();
            app.UseAuthentication();

            app.MapGet("/items/{userguid}/{lastid}", async (
                string userguid, int lastid, DbOps dbops) =>
            {
                var ret = await dbops.GetItems(userguid, lastid);
                return ret;
            });

            app.MapPost("/item", async (
                [FromBody] AddItemRequest reqdata, DbOps dbops) =>
            {
                var ret = await dbops.AddItem(reqdata);
                return ret;
            });

            app.MapGet("/updatedchats/{userguid}", async (
                string userguid, DbOps dbops) =>
            {
                var ret = await dbops.GetUpdatedChats(userguid);
                return ret;
            });

            app.MapGet("/clearchat/{userguid}", async (
                string userguid, DbOps dbops) =>
            {
                var ret = await dbops.ClearChat(userguid);
                return ret;
            });

            app.MapPost("/markchatanswered", async (
                [FromBody] MarkChatAnsweredRequest reqdata, DbOps dbops) =>
            {
                var ret = await dbops.MarkChatAnswered(reqdata);
                return ret;
            });

            app.MapGet("/login/{userguid}", (string userguid) =>
            {
                if (userguid != DbOps.AdminGuid)
                    return Results.Forbid();
                var token = UserManager.GenerateToken(userguid);
                return Results.Ok(token);
            });

            app.MapHub<SignalHub>("/signalhub");

            app.Run();
        }
    }
}
