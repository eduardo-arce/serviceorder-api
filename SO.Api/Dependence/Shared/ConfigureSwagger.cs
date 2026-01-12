using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace SO.Api.Dependence.Shared
{
    public class ConfigureSwagger
    {
        public static void Initialize(WebApplication app)
        {
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Service Order API v1");
                    c.RoutePrefix = "swagger";
                });
            }
        }
    }
}
