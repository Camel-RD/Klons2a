using KlonsChatApiServer.Services;
using KlonsChatDb.Models;
using KlonsChatDto.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net;
using System.Threading.RateLimiting;

namespace KlonsChatApiServer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var connectionString =
                builder.Configuration.GetConnectionString(
                    "VotesConnection") ??
                    throw new InvalidOperationException("Connection string 'VotesConnection' not found.");

            DbOps.AdminGuid =
                builder.Configuration.GetSection("Admin:AdminId").Value ??
                    throw new InvalidOperationException("'Admin:AdminId' not found.");

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
                        .WithOrigins("http://localhost", "https://localhost")
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
                            QueueLimit = 10,
                            PermitLimit = 10,
                            Window = TimeSpan.FromSeconds(15)
                        }));
            });


            builder.Services.AddAuthorization();

            var app = builder.Build();

            app.UseAuthorization();

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


            app.Run();
        }
    }
}
