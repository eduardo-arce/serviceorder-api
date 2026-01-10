using Microsoft.EntityFrameworkCore;
using SO.Infra.Database;

namespace SO.Api.Dependence.Shared
{
    public class ExecuteMigration
    {
        public static void Initialize(WebApplication app)
        {
            using (var scope = app.Services.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<DatabaseContext>();

                var hasMigrations = db.Database
                    .GetAppliedMigrations()
                    .Any();

                if (!hasMigrations)
                {
                    db.Database.Migrate();
                }
            }
        }
    }
}
