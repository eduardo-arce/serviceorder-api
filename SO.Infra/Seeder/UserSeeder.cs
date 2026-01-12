using SO.Domain.Entity;
using SO.Service.Adapter.Cryptography;
using Microsoft.EntityFrameworkCore;

namespace SO.Infra.Seeder
{
    public class UserSeeder
    {
        public static void Execute(ModelBuilder builder, ICryptography cryptography)
        {
            builder.Entity<UserEntity>().HasData(
                new UserEntity("alice.smith@example.com", "alice.smith", cryptography.Hash("Alice123!"), true, true),
                new UserEntity("bob_johnson@example.com", "bob_johnson", cryptography.Hash("Bob456!"), true, true),
                new UserEntity("carol.williams@example.com", "carol.williams", cryptography.Hash("Carol789!"), false, true),
                new UserEntity("david_brown@example.com", "david_brown", cryptography.Hash("David321!"), false, true),
                new UserEntity("emily.jones@example.com", "emily.jones", cryptography.Hash("Emily654!"), false, true),
                new UserEntity("frank.miller@example.com", "frank_miller", cryptography.Hash("Frank987!"), false, false),
                new UserEntity("grace.davis@example.com", "grace.davis", cryptography.Hash("Grace111!"), false, true),
                new UserEntity("henry_garcia@example.com", "henry_garcia", cryptography.Hash("Henry222!"), false, true),
                new UserEntity("isabella.rodriguez@example.com", "isabella.rodriguez", cryptography.Hash("Isabella333!"), false, true),
                new UserEntity("jack.martin@example.com", "jack.martin", cryptography.Hash("Jack444!"), false, false),
                new UserEntity("karen_lee@example.com", "karen_lee", cryptography.Hash("Karen555!"), false, true),
                new UserEntity("liam.harris@example.com", "liam.harris", cryptography.Hash("Liam666!"), false, true),
                new UserEntity("mia_wilson@example.com", "mia_wilson", cryptography.Hash("Mia777!"), false, true),
                new UserEntity("noah.clark@example.com", "noah.clark", cryptography.Hash("Noah888!"), false, false),
                new UserEntity("olivia_moore@example.com", "olivia_moore", cryptography.Hash("Olivia999!"), false, true),
                new UserEntity("peter.evans@example.com", "peter.evans", cryptography.Hash("Peter123!"), false, true),
                new UserEntity("quinn_taylor@example.com", "quinn_taylor", cryptography.Hash("Quinn456!"), false, false),
                new UserEntity("rachel.adams@example.com", "rachel.adams", cryptography.Hash("Rachel789!"), false, true),
                new UserEntity("samuel_king@example.com", "samuel_king", cryptography.Hash("Samuel321!"), false, true),
                new UserEntity("tina.white@example.com", "tina.white", cryptography.Hash("Tina654!"), false, true)
            );
        }
    }
}
