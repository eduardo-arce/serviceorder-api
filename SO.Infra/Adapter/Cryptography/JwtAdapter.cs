using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using SO.Service.Adapter.Cryptography;

namespace SO.Infra.Adapter.Cryptography
{
    public class JwtAdapter : IToken
    {
        private readonly IConfiguration _configuration;
        public JwtAdapter(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string? Decode(string? token)
        {
            try
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var secret = _configuration["keys:auth"];
                if (secret is null) return null;
                var key = Encoding.ASCII.GetBytes(secret);
                tokenHandler.ValidateToken(token, new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ClockSkew = TimeSpan.Zero
                }, out SecurityToken validatedToken);


                var jwtToken = (JwtSecurityToken)validatedToken;
                var id = jwtToken.Claims.First(x => x.Type == "id").Value;

                return id;
            }
            catch
            {
                return string.Empty;
            }
            
        }

        public string Generate(string id)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var secret = _configuration["keys:auth"];
            var key = Encoding.ASCII.GetBytes(secret is not null ? secret : string.Empty);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]{
                    new Claim(type: "id", value: id)
                }),
                Expires = DateTime.Now.AddHours(8),
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(key),
                    SecurityAlgorithms.HmacSha256
                )
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
