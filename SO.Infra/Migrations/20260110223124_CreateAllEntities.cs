using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SO.Infra.Migrations
{
    /// <inheritdoc />
    public partial class CreateAllEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CheckList",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Question = table.Column<string>(type: "text", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheckList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    UserName = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false),
                    IsAdmin = table.Column<bool>(type: "boolean", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServiceOrder",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    UserEntityId = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceOrder", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServiceOrder_User_UserEntityId",
                        column: x => x.UserEntityId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Image",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    HashName = table.Column<string>(type: "text", nullable: false),
                    ServiceOrderId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Image", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Image_ServiceOrder_ServiceOrderId",
                        column: x => x.ServiceOrderId,
                        principalTable: "ServiceOrder",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                name: "IX_Image_ServiceOrderId",
                table: "Image",
                column: "ServiceOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Maintenance_CheckListId",
                table: "Maintenance",
                column: "CheckListId");

            migrationBuilder.CreateIndex(
                name: "IX_Maintenance_ServiceOrderId",
                table: "Maintenance",
                column: "ServiceOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceOrder_UserEntityId",
                table: "ServiceOrder",
                column: "UserEntityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Image");

            migrationBuilder.DropTable(
                name: "Maintenance");

            migrationBuilder.DropTable(
                name: "CheckList");

            migrationBuilder.DropTable(
                name: "ServiceOrder");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
