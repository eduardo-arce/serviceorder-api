using SO.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace SO.Infra.Seeder
{
    public class CheckListSeeder
    {
        public static void Execute(ModelBuilder builder)
        {
            builder.Entity<CheckListEntity>().HasData(
                new CheckListEntity("Equipamento liga corretamente", true),
                new CheckListEntity("Apresenta danos físicos visíveis", false),
                new CheckListEntity("Cabos e conexões estão em bom estado", true),
                new CheckListEntity("Teste funcional foi realizado após o serviço", true),
                new CheckListEntity("Cliente recebeu orientações de uso", false)
            );
        }
    }
}