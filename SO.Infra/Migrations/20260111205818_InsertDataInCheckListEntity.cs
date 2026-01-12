using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SO.Infra.Migrations
{
    /// <inheritdoc />
    public partial class InsertDataInCheckListEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Maintenance");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "2434f087-46d1-4ca5-b788-ed0ab20f214a");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "250d2cb7-c3a6-4ec8-beca-5199a9e4d1f1");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "2d5b00f1-ad89-437f-bbba-ee96bb111361");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "3486858e-005b-4182-8f76-a277d3c953f7");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "4c28aeb6-408a-45fd-a461-5b3cc298deea");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "5cae815d-7048-463e-9f3b-32aad7434fc1");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "66eff188-9919-4c94-9734-4334b2d4b9ef");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "6e4676f0-1f20-44d2-9945-97cc2318d0c3");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "7bc8c810-2444-4c7a-827d-a4c5372aa3d3");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "92c19972-0957-46c5-a070-f062461697d8");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "aa4fa48b-e31d-4df5-ab97-3444e0a8fb4e");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "ac9e2655-cc94-4b2c-8dd4-d5f0a9ceea68");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "b152f611-0a44-4a61-8e1b-914bb963e17d");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "b35f35e4-7bf4-4d6e-a8a7-887e1e69f1fd");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "d62a8442-b295-48f8-8bb0-95739abb5f8c");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "d9eaa607-4682-421c-808f-3546d606dded");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "e29b77ff-6785-4ba6-8717-925f74c5a808");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "e32b6ac9-c693-4fdd-997a-13e94dbad440");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "eca786c0-3d92-4abd-8214-cef90c05f5e1");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "fc5e9f04-fdbe-4fda-9965-d7ccabc80615");

            migrationBuilder.CreateTable(
                name: "CheckListResult",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    CheckListId = table.Column<string>(type: "text", nullable: false),
                    ServiceOrderId = table.Column<string>(type: "text", nullable: false),
                    IsOk = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheckListResult", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CheckListResult_CheckList_CheckListId",
                        column: x => x.CheckListId,
                        principalTable: "CheckList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CheckListResult_ServiceOrder_ServiceOrderId",
                        column: x => x.ServiceOrderId,
                        principalTable: "ServiceOrder",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_CheckListResult_CheckListId",
                table: "CheckListResult",
                column: "CheckListId");

            migrationBuilder.CreateIndex(
                name: "IX_CheckListResult_ServiceOrderId",
                table: "CheckListResult",
                column: "ServiceOrderId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CheckListResult");

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

            migrationBuilder.CreateTable(
                name: "Maintenance",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    CheckListId = table.Column<string>(type: "text", nullable: false),
                    ServiceOrderId = table.Column<string>(type: "text", nullable: false),
                    IsOk = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Maintenance", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Maintenance_CheckList_CheckListId",
                        column: x => x.CheckListId,
                        principalTable: "CheckList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Maintenance_ServiceOrder_ServiceOrderId",
                        column: x => x.ServiceOrderId,
                        principalTable: "ServiceOrder",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreatedAt", "Email", "IsActive", "IsAdmin", "Password", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { "2434f087-46d1-4ca5-b788-ed0ab20f214a", new DateTime(2026, 1, 10, 18, 31, 21, 828, DateTimeKind.Local).AddTicks(6454), "emily.jones@example.com", true, false, "$2a$11$bWhdPJfUemoywJAywwg9M.G9KNHFTLrxcPQRvMGi7oN1swMvBaYmu", null, "emily.jones" },
                    { "250d2cb7-c3a6-4ec8-beca-5199a9e4d1f1", new DateTime(2026, 1, 10, 18, 31, 22, 640, DateTimeKind.Local).AddTicks(32), "karen_lee@example.com", true, false, "$2a$11$EFgkYV1IMEYcl8V0jtqFgeHQVYbZRVKDxjLMN02kwoc/NNJq1QWGG", null, "karen_lee" },
                    { "2d5b00f1-ad89-437f-bbba-ee96bb111361", new DateTime(2026, 1, 10, 18, 31, 21, 571, DateTimeKind.Local).AddTicks(2813), "carol.williams@example.com", true, false, "$2a$11$MP5EAiiATJ.tTVdZspbkMety7RnE9B2vAG8/0uxdGhCh4jZgS23uG", null, "carol.williams" },
                    { "3486858e-005b-4182-8f76-a277d3c953f7", new DateTime(2026, 1, 10, 18, 31, 23, 452, DateTimeKind.Local).AddTicks(4326), "quinn_taylor@example.com", false, false, "$2a$11$oYnTDTfRLIDufdkp26jreutWIsjeI0suUYShclW9S80kAr.x/PmFm", null, "quinn_taylor" },
                    { "4c28aeb6-408a-45fd-a461-5b3cc298deea", new DateTime(2026, 1, 10, 18, 31, 22, 802, DateTimeKind.Local).AddTicks(2264), "liam.harris@example.com", true, false, "$2a$11$94bdh.M3IhWSdauBDour/uJt5IK0PLlDf4DC1HlhVF4FBztHvzike", null, "liam.harris" },
                    { "5cae815d-7048-463e-9f3b-32aad7434fc1", new DateTime(2026, 1, 10, 18, 31, 23, 712, DateTimeKind.Local).AddTicks(685), "samuel_king@example.com", true, false, "$2a$11$SjrLC.O4xI5Kw1Kn8mRhJuoJzjgrdrSSaFN1r3K1FAtMTzQ4Hgp4C", null, "samuel_king" },
                    { "66eff188-9919-4c94-9734-4334b2d4b9ef", new DateTime(2026, 1, 10, 18, 31, 22, 505, DateTimeKind.Local).AddTicks(2136), "jack.martin@example.com", false, false, "$2a$11$t4F7HJTbj9jtpgCr0xlfJua0XNJFtKqKfWM0m3xmJdkZ.IG3YWlkC", null, "jack.martin" },
                    { "6e4676f0-1f20-44d2-9945-97cc2318d0c3", new DateTime(2026, 1, 10, 18, 31, 21, 313, DateTimeKind.Local).AddTicks(6067), "alice.smith@example.com", true, true, "$2a$11$JdMs5jqZvmaG4Yzze8NRpuGc2Zh1eE0iScoNTFlhIgKh569q6djGa", null, "alice.smith" },
                    { "7bc8c810-2444-4c7a-827d-a4c5372aa3d3", new DateTime(2026, 1, 10, 18, 31, 22, 93, DateTimeKind.Local).AddTicks(1705), "grace.davis@example.com", true, false, "$2a$11$dzt5ffgPNIPkLAR4wBx7ae6AG.10HVDV70gLpbFSuBwX7jMzcujtq", null, "grace.davis" },
                    { "92c19972-0957-46c5-a070-f062461697d8", new DateTime(2026, 1, 10, 18, 31, 23, 192, DateTimeKind.Local).AddTicks(4831), "olivia_moore@example.com", true, false, "$2a$11$fwi7rrpiGJAMqqHWZQECguB/BB8wJOSnmK8xDbmWQPTCYMXbJkOkm", null, "olivia_moore" },
                    { "aa4fa48b-e31d-4df5-ab97-3444e0a8fb4e", new DateTime(2026, 1, 10, 18, 31, 22, 933, DateTimeKind.Local).AddTicks(9975), "mia_wilson@example.com", true, false, "$2a$11$lvK8Nowca1XwZTjfxOn72uxJXv0Rp9E1SPLLwH9lXq3mgUhPveMue", null, "mia_wilson" },
                    { "ac9e2655-cc94-4b2c-8dd4-d5f0a9ceea68", new DateTime(2026, 1, 10, 18, 31, 23, 582, DateTimeKind.Local).AddTicks(5180), "rachel.adams@example.com", true, false, "$2a$11$EkI7Xp8P0bMC8y9QGesQDOnMz6v0JzSPxNdwcJTLArqTG87Xhm.fq", null, "rachel.adams" },
                    { "b152f611-0a44-4a61-8e1b-914bb963e17d", new DateTime(2026, 1, 10, 18, 31, 22, 359, DateTimeKind.Local).AddTicks(8265), "isabella.rodriguez@example.com", true, false, "$2a$11$Eo4S27.UD4Vp3ZHMrojRYeWRIPP7bi4vKJBwEAcR8HSsiaFdB6GxC", null, "isabella.rodriguez" },
                    { "b35f35e4-7bf4-4d6e-a8a7-887e1e69f1fd", new DateTime(2026, 1, 10, 18, 31, 22, 225, DateTimeKind.Local).AddTicks(9320), "henry_garcia@example.com", true, false, "$2a$11$J0DSbLtj5bEIJuTQrkhfueNj3dFHbBovC50WyFTSRAUdT/4atii1S", null, "henry_garcia" },
                    { "d62a8442-b295-48f8-8bb0-95739abb5f8c", new DateTime(2026, 1, 10, 18, 31, 23, 840, DateTimeKind.Local).AddTicks(980), "tina.white@example.com", true, false, "$2a$11$HPeQFqG0XhlUDRcUNqLsxeOJ8.5ZsGIvH0bDJScktY6Hm68XRGKIi", null, "tina.white" },
                    { "d9eaa607-4682-421c-808f-3546d606dded", new DateTime(2026, 1, 10, 18, 31, 23, 322, DateTimeKind.Local).AddTicks(9209), "peter.evans@example.com", true, false, "$2a$11$rVuLd8U9OJAw0WeR0RDZlu4YBLh1yJZF06YuVW8JrJI8I4q.qBsTG", null, "peter.evans" },
                    { "e29b77ff-6785-4ba6-8717-925f74c5a808", new DateTime(2026, 1, 10, 18, 31, 21, 442, DateTimeKind.Local).AddTicks(9902), "bob_johnson@example.com", true, true, "$2a$11$HmbrlH7Zz/wBsZ1EWaN8y.XhkDhuStZUQwoSgXxOKS5xp8LwUZnce", null, "bob_johnson" },
                    { "e32b6ac9-c693-4fdd-997a-13e94dbad440", new DateTime(2026, 1, 10, 18, 31, 21, 699, DateTimeKind.Local).AddTicks(7437), "david_brown@example.com", true, false, "$2a$11$qf8RSRTYylZcgCb/hjQAaOt7IfMRAJlP9FCRgDRWdSKH5NKoLTg.G", null, "david_brown" },
                    { "eca786c0-3d92-4abd-8214-cef90c05f5e1", new DateTime(2026, 1, 10, 18, 31, 21, 959, DateTimeKind.Local).AddTicks(4085), "frank.miller@example.com", false, false, "$2a$11$sO3YguQ/fOHCc1G9d.F4ze6dfmbdEEiO8L26t.SDEJrW8isAIUNiK", null, "frank_miller" },
                    { "fc5e9f04-fdbe-4fda-9965-d7ccabc80615", new DateTime(2026, 1, 10, 18, 31, 23, 64, DateTimeKind.Local).AddTicks(3278), "noah.clark@example.com", false, false, "$2a$11$Wa0HHgo5jIBGySvqBIdhSehPF4KSddDwR3XdNqAZyIca2wLewn9.2", null, "noah.clark" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Maintenance_CheckListId",
                table: "Maintenance",
                column: "CheckListId");

            migrationBuilder.CreateIndex(
                name: "IX_Maintenance_ServiceOrderId",
                table: "Maintenance",
                column: "ServiceOrderId");
        }
    }
}
