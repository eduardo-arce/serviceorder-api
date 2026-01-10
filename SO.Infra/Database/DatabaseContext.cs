using Microsoft.EntityFrameworkCore;
using SO.Domain.Entity;
using SO.Infra.Seeder;
using SO.Service.Adapter.Cryptography;

namespace SO.Infra.Database
{
    public class DatabaseContext : DbContext
    {
        private readonly ICryptography _cryptography;

        public DatabaseContext(DbContextOptions<DatabaseContext> options,
            ICryptography cryptography) : base(options)
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            _cryptography = cryptography;
        }

        public DbSet<CheckListEntity> CheckList { get; set; } = null!;
        public DbSet<ImageEntity> Image { get; set; } = null!;
        public DbSet<CheckListResultEntity> CheckListResult { get; set; } = null!;
        public DbSet<ServiceOrderEntity> ServiceOrder { get; set; } = null!;
        public DbSet<UserEntity> User { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            UserSeerder.Execute(builder, _cryptography);

            base.OnModelCreating(builder);
        }
    } 
}
