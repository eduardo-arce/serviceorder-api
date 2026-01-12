using Microsoft.EntityFrameworkCore;
using SO.Infra.Database;

namespace SO.Api.Dependence.Shared
{
    public class DatabaseDependence
    {
        public static void Initialize(WebApplicationBuilder builder)
        {
            var connectionString = Environment.GetEnvironmentVariable("DB_CONNECTION_STRING") ??
                builder.Configuration["Database:ConnectionString"];

            builder.Services.AddDbContext<DatabaseContext>(options =>
            {
                options.UseNpgsql(connectionString);
            });
        }
    }
}
