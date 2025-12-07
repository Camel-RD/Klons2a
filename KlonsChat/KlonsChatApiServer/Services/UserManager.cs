using Microsoft.AspNetCore.SignalR;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace KlonsChatApiServer.Services
{
    public static class UserManager
    {
        public static JwtConfig TokenConfig;
        public static RateLimiterConfig RateLimiter;

        public class RateLimiterConfig
        {
            public bool Enabled { get; set; }
            public int Window { get; set; }
            public int PermitLimit { get; set; }
            public int QueueLimit { get; set; }
        }

        public class JwtConfig
        {
            public string Secret { get; set; }
            public string Issuer { get; set; }
            public string Audience { get; set; }
        }

        public static string GetUserId(HubCallerContext connection)
        {
            return connection.User?.Identity?.Name ?? string.Empty;
        }

        public static string GetUserId(HubConnectionContext connection)
        {
            return connection.User?.Identity?.Name ?? string.Empty;
        }

        public static string GenerateToken(string userName)
        {
            if (TokenConfig?.Secret is null || TokenConfig?.Issuer is null || TokenConfig?.Audience is null)
            {
                throw new ApplicationException("Jwt is not set in the configuration");
            }
            var signingKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(TokenConfig.Secret));
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenDescriptor = new SecurityTokenDescriptor()
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.NameIdentifier, userName),
                    new Claim(ClaimTypes.Name, userName)
                }),
                Expires = DateTime.UtcNow.AddDays(1),
                Issuer = TokenConfig.Issuer,
                Audience = TokenConfig.Audience,
                SigningCredentials = new SigningCredentials(signingKey, SecurityAlgorithms.HmacSha256Signature)
            };
            var securityToken = tokenHandler.CreateToken(tokenDescriptor);
            var token = tokenHandler.WriteToken(securityToken);
            return token;
        }

    }
}
