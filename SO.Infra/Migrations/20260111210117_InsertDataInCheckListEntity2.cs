using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SO.Infra.Migrations
{
    /// <inheritdoc />
    public partial class InsertDataInCheckListEntity2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "00589b1e-c677-494f-90f1-e949bacfc8a2");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "03e9b1e0-1cd2-4eaa-9d59-8bbb96b9eda9");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "09762cad-ebd2-4fba-9485-c64877ae4a59");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "142c172e-656f-47f1-a8dd-c1802a9ced7b");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "183cd2df-c2c5-4be7-9614-2cafc5222e5f");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "18b65281-49b6-4b3a-8a2c-71d46b925b18");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "25f38fb0-cfad-48f6-b01d-da5ba1cb3203");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "30618d8b-463b-4168-9dba-92b0b5bb3ba6");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "3363f5e4-4ce8-451f-9849-4ad9d0c54abd");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "57344a53-b7da-4429-afbc-ea9441f210e5");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "585f9d7d-22cf-47e0-9334-7c5658bf9044");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "59a5056a-8ddd-4cf3-a697-392434281bdc");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "5d5ce925-1cc1-47fa-89e4-638804a813e0");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "621171c8-8669-4ad3-8a16-360c6edbef17");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "869a29f2-3f98-4717-9bb8-50357594895a");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "8dfe6be2-f322-4bd4-9624-b5b287df7472");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "a3ecdde6-dbd7-4c27-8b1d-406a62dafa21");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "aaa80d37-767f-4a5e-a0c4-d893b50d28e4");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "e7b3fdf5-c212-4740-93b7-10b40b52cb93");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "fcf946ed-edc1-45d4-a6a4-a6b0f122584e");

            migrationBuilder.InsertData(
                table: "CheckList",
                columns: new[] { "Id", "IsActive", "Question" },
                values: new object[,]
                {
                    { "1ce1b2f4-e6e1-4806-9c89-922e95b9abdb", false, "Apresenta danos físicos visíveis" },
                    { "2a7972e8-ec2f-434a-b51c-be7d6dc0606e", false, "Cliente recebeu orientações de uso" },
                    { "7597f070-ef1f-4b5e-8fb6-57fc4eec30ee", true, "Equipamento liga corretamente" },
                    { "aaae8562-0eb8-44ce-af4b-392567fbf49e", true, "Teste funcional foi realizado após o serviço" },
                    { "cecf6d13-871b-453a-b008-74e4ac2cd207", true, "Cabos e conexões estão em bom estado" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreatedAt", "Email", "IsActive", "IsAdmin", "Password", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { "0659da46-c0c0-4bfe-965f-3e17ad11bcb7", new DateTime(2026, 1, 11, 17, 1, 15, 859, DateTimeKind.Local).AddTicks(9017), "grace.davis@example.com", true, false, "$2a$11$s9FaF0Az1r/P19JWy.DBKu8893MuoYXRX/IH1b.sU52n.F9kgUD8O", null, "grace.davis" },
                    { "0bd0f8a1-c2b0-4e6e-b10e-41c58d0f1797", new DateTime(2026, 1, 11, 17, 1, 16, 508, DateTimeKind.Local).AddTicks(6015), "liam.harris@example.com", true, false, "$2a$11$qLb063/ZNVbLrVVkXVn5wetalCWGXQpDeiQgMRbytN/viPoLp0GBS", null, "liam.harris" },
                    { "0e2ac754-7322-48d8-be25-098ed83fce09", new DateTime(2026, 1, 11, 17, 1, 17, 414, DateTimeKind.Local).AddTicks(6980), "samuel_king@example.com", true, false, "$2a$11$1ryCMolagAluuMEmdzOuy.nEPFbTnmJDoDb88vW/fnNGiOfH0vkL.", null, "samuel_king" },
                    { "34876b45-0600-49e4-83aa-860af1b66505", new DateTime(2026, 1, 11, 17, 1, 17, 284, DateTimeKind.Local).AddTicks(9641), "rachel.adams@example.com", true, false, "$2a$11$fXJlcqjgHJBOKpTutGt2o.C.8yR6.csCX7DgGWT8VIIqbn4BCtfj6", null, "rachel.adams" },
                    { "4f0a0726-a12b-48bb-a0a3-7ae442037b58", new DateTime(2026, 1, 11, 17, 1, 15, 471, DateTimeKind.Local).AddTicks(7286), "david_brown@example.com", true, false, "$2a$11$Pie2dwRfYWCdGN.armTwPuP8Mr7//m/1e6u9l9E9ZKK43HtBSwaIW", null, "david_brown" },
                    { "52bfe38c-26f1-4d88-9d4a-d72679dea98f", new DateTime(2026, 1, 11, 17, 1, 17, 26, DateTimeKind.Local).AddTicks(3249), "peter.evans@example.com", true, false, "$2a$11$G.DyTwpXyThx1AtYdSnJY..VZ9JTrktBotHkdMaIfwqR7D9kyhUbC", null, "peter.evans" },
                    { "541b4a98-3fe5-4bbb-9ea0-83186d8cce59", new DateTime(2026, 1, 11, 17, 1, 15, 75, DateTimeKind.Local).AddTicks(9228), "alice.smith@example.com", true, true, "$2a$11$wHq4MvtWz6xhGZPrAUXIY.7nUCTY/jycbEt2HBMSXcsbMFXVJBGk2", null, "alice.smith" },
                    { "67c51451-1a36-450a-b10a-d6ffb62a4f85", new DateTime(2026, 1, 11, 17, 1, 16, 636, DateTimeKind.Local).AddTicks(5325), "mia_wilson@example.com", true, false, "$2a$11$2mGV5eVux8vxJZ8IguOAQu5pOGHSbqB4bdwdAAgSVoN5w5rTepXbe", null, "mia_wilson" },
                    { "82ca5889-8feb-49de-9fbc-df51b3c4fe21", new DateTime(2026, 1, 11, 17, 1, 16, 246, DateTimeKind.Local).AddTicks(257), "jack.martin@example.com", false, false, "$2a$11$zbCXqfN/DpWHhIKBcdGLHuTgpyH8ZldJPI9pThQOVek270xYm767u", null, "jack.martin" },
                    { "867c022f-c506-46e1-9507-7975d4c7b13b", new DateTime(2026, 1, 11, 17, 1, 15, 988, DateTimeKind.Local).AddTicks(9127), "henry_garcia@example.com", true, false, "$2a$11$yXXVZKmpGvB0EU2QECPno.DAcuPMIWfpKj5EmIJL9Jv3NeFw/nGQW", null, "henry_garcia" },
                    { "918d5e65-bd09-4654-a6e0-d8e3c53f5064", new DateTime(2026, 1, 11, 17, 1, 16, 895, DateTimeKind.Local).AddTicks(3105), "olivia_moore@example.com", true, false, "$2a$11$zYs2cMSgKLQ7iE9w/0NDw.VWtqRPY47j.NSDJfa2STgjbUJPujioS", null, "olivia_moore" },
                    { "9b3ba930-c8d8-4796-9c87-920393880df6", new DateTime(2026, 1, 11, 17, 1, 16, 764, DateTimeKind.Local).AddTicks(6286), "noah.clark@example.com", false, false, "$2a$11$.QliIQvDHAhLgSkK5qfsKeHRuK8YsCUmbIYVnaUsDRuaCDChkHFBG", null, "noah.clark" },
                    { "9de2913e-a560-43e9-b8ca-205916cbea7f", new DateTime(2026, 1, 11, 17, 1, 16, 379, DateTimeKind.Local).AddTicks(4322), "karen_lee@example.com", true, false, "$2a$11$KZmlYQTY0rXLM8kO9w2Po.7SvniUqRTvM0KbsdjtVgWd0j8Xfqkwa", null, "karen_lee" },
                    { "a783ffd0-e771-4060-b200-84f50f371e9e", new DateTime(2026, 1, 11, 17, 1, 15, 728, DateTimeKind.Local).AddTicks(8251), "frank.miller@example.com", false, false, "$2a$11$FNNEWsQncgUNNOJznzJKbeycb8tRIST46u7eia4npdwbYt7I/DVlK", null, "frank_miller" },
                    { "b18af8f0-e9a8-4ed1-a0ff-0c83851029d6", new DateTime(2026, 1, 11, 17, 1, 17, 156, DateTimeKind.Local).AddTicks(9817), "quinn_taylor@example.com", false, false, "$2a$11$pY8vHxg3myNvUFXd1PcNP.pNXCtLDvSOnucWGy2MT8L2k2MlT02iK", null, "quinn_taylor" },
                    { "b91b9d4e-b662-416d-b8f2-eba4fa02343b", new DateTime(2026, 1, 11, 17, 1, 15, 600, DateTimeKind.Local).AddTicks(1384), "emily.jones@example.com", true, false, "$2a$11$uPgur8Du2pq7JzFY9jumje/9Am8sO4nSpEO8dzs..RPkaVhwIFpFm", null, "emily.jones" },
                    { "ca168f0a-fef9-4959-b5d8-9238e5c8a2de", new DateTime(2026, 1, 11, 17, 1, 15, 212, DateTimeKind.Local).AddTicks(1595), "bob_johnson@example.com", true, true, "$2a$11$.DQmkAp.aOJ2yfSmms68yOscYrk9n9rTPof0qBai/YFDeCagP9T6u", null, "bob_johnson" },
                    { "d3ea82b5-5680-4303-9e39-0f1c3ea77a37", new DateTime(2026, 1, 11, 17, 1, 17, 542, DateTimeKind.Local).AddTicks(9207), "tina.white@example.com", true, false, "$2a$11$XW06DZRcazVd0oBFFUwI2u/uJFiVg7Ws8KBwGSJ3lcaE0.xeV0cd.", null, "tina.white" },
                    { "e9aa49df-863d-4287-aa77-d88d1a98c2df", new DateTime(2026, 1, 11, 17, 1, 15, 343, DateTimeKind.Local).AddTicks(4759), "carol.williams@example.com", true, false, "$2a$11$eSPh9STq0aDW7IC1OWegHO90Ylm5493qXmwwBmGf5qozIv/cFRJsi", null, "carol.williams" },
                    { "ff643df4-d9bd-4f01-9c91-8e03b6f8f749", new DateTime(2026, 1, 11, 17, 1, 16, 117, DateTimeKind.Local).AddTicks(8959), "isabella.rodriguez@example.com", true, false, "$2a$11$DJIbBQW4luqPN8VUgU3IA.91JVLRb73Grl2HALEJhJvwMYHXxC.2.", null, "isabella.rodriguez" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CheckList",
                keyColumn: "Id",
                keyValue: "1ce1b2f4-e6e1-4806-9c89-922e95b9abdb");

            migrationBuilder.DeleteData(
                table: "CheckList",
                keyColumn: "Id",
                keyValue: "2a7972e8-ec2f-434a-b51c-be7d6dc0606e");

            migrationBuilder.DeleteData(
                table: "CheckList",
                keyColumn: "Id",
                keyValue: "7597f070-ef1f-4b5e-8fb6-57fc4eec30ee");

            migrationBuilder.DeleteData(
                table: "CheckList",
                keyColumn: "Id",
                keyValue: "aaae8562-0eb8-44ce-af4b-392567fbf49e");

            migrationBuilder.DeleteData(
                table: "CheckList",
                keyColumn: "Id",
                keyValue: "cecf6d13-871b-453a-b008-74e4ac2cd207");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "0659da46-c0c0-4bfe-965f-3e17ad11bcb7");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "0bd0f8a1-c2b0-4e6e-b10e-41c58d0f1797");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "0e2ac754-7322-48d8-be25-098ed83fce09");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "34876b45-0600-49e4-83aa-860af1b66505");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "4f0a0726-a12b-48bb-a0a3-7ae442037b58");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "52bfe38c-26f1-4d88-9d4a-d72679dea98f");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "541b4a98-3fe5-4bbb-9ea0-83186d8cce59");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "67c51451-1a36-450a-b10a-d6ffb62a4f85");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "82ca5889-8feb-49de-9fbc-df51b3c4fe21");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "867c022f-c506-46e1-9507-7975d4c7b13b");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "918d5e65-bd09-4654-a6e0-d8e3c53f5064");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "9b3ba930-c8d8-4796-9c87-920393880df6");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "9de2913e-a560-43e9-b8ca-205916cbea7f");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "a783ffd0-e771-4060-b200-84f50f371e9e");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "b18af8f0-e9a8-4ed1-a0ff-0c83851029d6");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "b91b9d4e-b662-416d-b8f2-eba4fa02343b");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "ca168f0a-fef9-4959-b5d8-9238e5c8a2de");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "d3ea82b5-5680-4303-9e39-0f1c3ea77a37");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "e9aa49df-863d-4287-aa77-d88d1a98c2df");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "ff643df4-d9bd-4f01-9c91-8e03b6f8f749");

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreatedAt", "Email", "IsActive", "IsAdmin", "Password", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { "00589b1e-c677-494f-90f1-e949bacfc8a2", new DateTime(2026, 1, 11, 16, 58, 15, 825, DateTimeKind.Local).AddTicks(3472), "emily.jones@example.com", true, false, "$2a$11$1/vARFhCP9jeqgGxg6bJYunA1Ji4ZuiysmzQTIGGa1YXms72RJC7e", null, "emily.jones" },
                    { "03e9b1e0-1cd2-4eaa-9d59-8bbb96b9eda9", new DateTime(2026, 1, 11, 16, 58, 15, 953, DateTimeKind.Local).AddTicks(5816), "frank.miller@example.com", false, false, "$2a$11$qcWPpc3.RgNtBkm38tU0jeFYmXcyZIJogzcj4.gsV7WOXQ73TMl8e", null, "frank_miller" },
                    { "09762cad-ebd2-4fba-9485-c64877ae4a59", new DateTime(2026, 1, 11, 16, 58, 16, 996, DateTimeKind.Local).AddTicks(752), "noah.clark@example.com", false, false, "$2a$11$IQxlApbUft3qzlzcPmahuOzE7NbIM2JgX.0Y.QyP0x8dpc6TuhnY.", null, "noah.clark" },
                    { "142c172e-656f-47f1-a8dd-c1802a9ced7b", new DateTime(2026, 1, 11, 16, 58, 17, 511, DateTimeKind.Local).AddTicks(6979), "rachel.adams@example.com", true, false, "$2a$11$T6bHMO1QLTAxQSZ5VVZyyOg4027IIxTVj/xovQTKn12Sdh56LeYAW", null, "rachel.adams" },
                    { "183cd2df-c2c5-4be7-9614-2cafc5222e5f", new DateTime(2026, 1, 11, 16, 58, 16, 596, DateTimeKind.Local).AddTicks(9913), "karen_lee@example.com", true, false, "$2a$11$Wwn/4p29Cn.mqS2zEBv9..p4BEgi14nLDJ1FgkLPOP0i5BA/RYspa", null, "karen_lee" },
                    { "18b65281-49b6-4b3a-8a2c-71d46b925b18", new DateTime(2026, 1, 11, 16, 58, 15, 306, DateTimeKind.Local).AddTicks(7217), "alice.smith@example.com", true, true, "$2a$11$Q1dslu.6bIpBzwb/O3VfH.djYcG.jTIgv05ZhmKFPf2yMxZHsFe6.", null, "alice.smith" },
                    { "25f38fb0-cfad-48f6-b01d-da5ba1cb3203", new DateTime(2026, 1, 11, 16, 58, 15, 567, DateTimeKind.Local).AddTicks(7273), "carol.williams@example.com", true, false, "$2a$11$kTLOEq6/yZijzL2P7vDI/uveHOuCDQyRLkM8rmlpgXJvOHuIMuXha", null, "carol.williams" },
                    { "30618d8b-463b-4168-9dba-92b0b5bb3ba6", new DateTime(2026, 1, 11, 16, 58, 16, 468, DateTimeKind.Local).AddTicks(664), "jack.martin@example.com", false, false, "$2a$11$0yoSzt73Xe4aA9q3PQvjtupjMQV4DdQR.SepggOpqFZM9RQCFFfAK", null, "jack.martin" },
                    { "3363f5e4-4ce8-451f-9849-4ad9d0c54abd", new DateTime(2026, 1, 11, 16, 58, 16, 863, DateTimeKind.Local).AddTicks(3958), "mia_wilson@example.com", true, false, "$2a$11$/VuLdh85eObBacIg60fkSuch6Y2trWMlIsV5irF5Wc2XKb7tf96Oi", null, "mia_wilson" },
                    { "57344a53-b7da-4429-afbc-ea9441f210e5", new DateTime(2026, 1, 11, 16, 58, 16, 210, DateTimeKind.Local).AddTicks(5939), "henry_garcia@example.com", true, false, "$2a$11$Zxcn765NSZfOpUR51W2pDORFTq9n81uyn7k9xIjXgD/zVKYHbJMxW", null, "henry_garcia" },
                    { "585f9d7d-22cf-47e0-9334-7c5658bf9044", new DateTime(2026, 1, 11, 16, 58, 17, 770, DateTimeKind.Local).AddTicks(3123), "tina.white@example.com", true, false, "$2a$11$F67oAplZvtsaRXwfGOMajuv5GQFBk/mcxmSFbctz2xiyw3YSGcZFC", null, "tina.white" },
                    { "59a5056a-8ddd-4cf3-a697-392434281bdc", new DateTime(2026, 1, 11, 16, 58, 16, 727, DateTimeKind.Local).AddTicks(4592), "liam.harris@example.com", true, false, "$2a$11$1vM2uqvrqQD9UsPCq1SHcuAnYH5yBsk80z4PvhkWpxiKXk2sEcjU.", null, "liam.harris" },
                    { "5d5ce925-1cc1-47fa-89e4-638804a813e0", new DateTime(2026, 1, 11, 16, 58, 17, 640, DateTimeKind.Local).AddTicks(3342), "samuel_king@example.com", true, false, "$2a$11$O.T6SkSYC6nHl6Txpvj/meGgCUw5cEowWSvWq64EScGrdEH2YgSA2", null, "samuel_king" },
                    { "621171c8-8669-4ad3-8a16-360c6edbef17", new DateTime(2026, 1, 11, 16, 58, 15, 437, DateTimeKind.Local).AddTicks(8803), "bob_johnson@example.com", true, true, "$2a$11$A9IajfM0wT8GEdbmYSO3hOyWQ5rgly7RcCwnTZAElFRYNjLhRp2PS", null, "bob_johnson" },
                    { "869a29f2-3f98-4717-9bb8-50357594895a", new DateTime(2026, 1, 11, 16, 58, 17, 124, DateTimeKind.Local).AddTicks(3522), "olivia_moore@example.com", true, false, "$2a$11$8z/DZgWmlNGp3lnafdtKMufy.AjxISGe7LWTFSHvofwKfk.MDOkjO", null, "olivia_moore" },
                    { "8dfe6be2-f322-4bd4-9624-b5b287df7472", new DateTime(2026, 1, 11, 16, 58, 17, 252, DateTimeKind.Local).AddTicks(9955), "peter.evans@example.com", true, false, "$2a$11$3ldRQmU.I1yRrMiwCqxW.ebtPHJBZL/59VH8CcrOQvObnFNYZvYE6", null, "peter.evans" },
                    { "a3ecdde6-dbd7-4c27-8b1d-406a62dafa21", new DateTime(2026, 1, 11, 16, 58, 15, 695, DateTimeKind.Local).AddTicks(5584), "david_brown@example.com", true, false, "$2a$11$DcVzr/EAZ6TvPT4wkk7FsOMaHlXTE3idB2EwhOKD6AhbReeveDzKm", null, "david_brown" },
                    { "aaa80d37-767f-4a5e-a0c4-d893b50d28e4", new DateTime(2026, 1, 11, 16, 58, 16, 82, DateTimeKind.Local).AddTicks(1246), "grace.davis@example.com", true, false, "$2a$11$tUg0DNsaOOh65mqxidWuX.5qjlOnPuWSH4r0KgY7nXJx0XIF1cj.m", null, "grace.davis" },
                    { "e7b3fdf5-c212-4740-93b7-10b40b52cb93", new DateTime(2026, 1, 11, 16, 58, 17, 383, DateTimeKind.Local).AddTicks(3014), "quinn_taylor@example.com", false, false, "$2a$11$bq8Z3he9j6YYMZWh5hQGUeuvKFgPohBJ8mE5GbLyHIymPaYfO8kv6", null, "quinn_taylor" },
                    { "fcf946ed-edc1-45d4-a6a4-a6b0f122584e", new DateTime(2026, 1, 11, 16, 58, 16, 339, DateTimeKind.Local).AddTicks(4051), "isabella.rodriguez@example.com", true, false, "$2a$11$rb4rYHCL3bnYmm5oB2LM4eFQAi3PITp4zCY.QR1CwcjJT2cSaP0wG", null, "isabella.rodriguez" }
                });
        }
    }
}
