using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DuettServerDomain.Migrations
{
    /// <inheritdoc />
    public partial class sqlitelocalmigration659 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ListItems",
                keyColumn: "id",
                keyValue: new Guid("36923066-5050-4a24-ba89-bc663fe9a722"));

            migrationBuilder.DeleteData(
                table: "ListItems",
                keyColumn: "id",
                keyValue: new Guid("386396c0-1f10-46c7-88a7-c6eb771078d4"));

            migrationBuilder.DeleteData(
                table: "ListItems",
                keyColumn: "id",
                keyValue: new Guid("49fe3d00-d7b8-401e-9b9a-f2a31bb1d1cb"));

            migrationBuilder.DeleteData(
                table: "ListItems",
                keyColumn: "id",
                keyValue: new Guid("7a697737-afb8-45c8-81ed-7f761ca6e270"));

            migrationBuilder.DeleteData(
                table: "ListItems",
                keyColumn: "id",
                keyValue: new Guid("bd7308c5-f486-4d62-b291-24bb27892331"));

            migrationBuilder.DeleteData(
                table: "ListItems",
                keyColumn: "id",
                keyValue: new Guid("c22e1cf5-8dc3-42b4-bdef-2aff5b8e59b1"));

            migrationBuilder.InsertData(
                table: "ListItems",
                columns: new[] { "id", "AValue", "BValue", "Description" },
                values: new object[,]
                {
                    { new Guid("0e6e811e-c466-4eaf-a259-c1b6ecb2ae51"), 30, 14, "Maçã" },
                    { new Guid("7ab83819-a14b-452e-a4eb-7bde89bd0f5a"), 17, 73, "Uva" },
                    { new Guid("b18357f1-567c-4743-b8b3-cf24ac4fdac4"), 15, 25, "Banana" },
                    { new Guid("bfa1d80d-5c24-42b1-b747-02d713479487"), 8, 1, "Melancia" },
                    { new Guid("c45d13ee-cf51-4da4-a5d9-4df25f99e7ec"), 35, 10, "Abacaxi" },
                    { new Guid("c83c79b8-ab04-4c0c-9987-b15c15471b66"), 8, 12, "Pêra" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ListItems",
                keyColumn: "id",
                keyValue: new Guid("0e6e811e-c466-4eaf-a259-c1b6ecb2ae51"));

            migrationBuilder.DeleteData(
                table: "ListItems",
                keyColumn: "id",
                keyValue: new Guid("7ab83819-a14b-452e-a4eb-7bde89bd0f5a"));

            migrationBuilder.DeleteData(
                table: "ListItems",
                keyColumn: "id",
                keyValue: new Guid("b18357f1-567c-4743-b8b3-cf24ac4fdac4"));

            migrationBuilder.DeleteData(
                table: "ListItems",
                keyColumn: "id",
                keyValue: new Guid("bfa1d80d-5c24-42b1-b747-02d713479487"));

            migrationBuilder.DeleteData(
                table: "ListItems",
                keyColumn: "id",
                keyValue: new Guid("c45d13ee-cf51-4da4-a5d9-4df25f99e7ec"));

            migrationBuilder.DeleteData(
                table: "ListItems",
                keyColumn: "id",
                keyValue: new Guid("c83c79b8-ab04-4c0c-9987-b15c15471b66"));

            migrationBuilder.InsertData(
                table: "ListItems",
                columns: new[] { "id", "AValue", "BValue", "Description" },
                values: new object[,]
                {
                    { new Guid("36923066-5050-4a24-ba89-bc663fe9a722"), 30, 14, "Maçã" },
                    { new Guid("386396c0-1f10-46c7-88a7-c6eb771078d4"), 8, 1, "Melancia" },
                    { new Guid("49fe3d00-d7b8-401e-9b9a-f2a31bb1d1cb"), 15, 25, "Banana" },
                    { new Guid("7a697737-afb8-45c8-81ed-7f761ca6e270"), 35, 10, "Abacaxi" },
                    { new Guid("bd7308c5-f486-4d62-b291-24bb27892331"), 8, 12, "Pêra" },
                    { new Guid("c22e1cf5-8dc3-42b4-bdef-2aff5b8e59b1"), 17, 73, "Uva" }
                });
        }
    }
}
