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
        public static string Secret;
        public static string Issuer;
        public static string Audience;

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
            if (Secret is null || Issuer is null || Audience is null)
            {
                throw new ApplicationException("Jwt is not set in the configuration");
            }
            var signingKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Secret));
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenDescriptor = new SecurityTokenDescriptor()
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.NameIdentifier, userName),
                    new Claim(ClaimTypes.Name, userName)
                }),
                Expires = DateTime.UtcNow.AddDays(1),
                Issuer = Issuer,
                Audience = Audience,
                SigningCredentials = new SigningCredentials(signingKey, SecurityAlgorithms.HmacSha256Signature)
            };
            var securityToken = tokenHandler.CreateToken(tokenDescriptor);
            var token = tokenHandler.WriteToken(securityToken);
            return token;
        }

    }
}
