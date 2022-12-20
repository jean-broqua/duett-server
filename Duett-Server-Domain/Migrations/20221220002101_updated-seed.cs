using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DuettServerDomain.Migrations
{
    /// <inheritdoc />
    public partial class updatedseed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ListItems",
                keyColumn: "id",
                keyValue: new Guid("0837b971-8874-41da-a3e0-29d4ab98f34a"));

            migrationBuilder.DeleteData(
                table: "ListItems",
                keyColumn: "id",
                keyValue: new Guid("2956395b-8f6a-4e06-8472-d70ad184e815"));

            migrationBuilder.DeleteData(
                table: "ListItems",
                keyColumn: "id",
                keyValue: new Guid("bc78a37d-838a-47b9-8f6c-8f824c97aebf"));

            migrationBuilder.DeleteData(
                table: "ListItems",
                keyColumn: "id",
                keyValue: new Guid("ca62e688-cf16-4f32-ac3c-0a5d652d5e5f"));

            migrationBuilder.DeleteData(
                table: "ListItems",
                keyColumn: "id",
                keyValue: new Guid("cbb379f6-dad9-4730-b526-092028bf6c29"));

            migrationBuilder.DeleteData(
                table: "ListItems",
                keyColumn: "id",
                keyValue: new Guid("ce97032e-e752-4924-9bae-3e07cd833115"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("0837b971-8874-41da-a3e0-29d4ab98f34a"), 17, 73, "Uva" },
                    { new Guid("2956395b-8f6a-4e06-8472-d70ad184e815"), 35, 10, "Abacaxi" },
                    { new Guid("bc78a37d-838a-47b9-8f6c-8f824c97aebf"), 15, 25, "Banana" },
                    { new Guid("ca62e688-cf16-4f32-ac3c-0a5d652d5e5f"), 8, 1, "Melancia" },
                    { new Guid("cbb379f6-dad9-4730-b526-092028bf6c29"), 8, 12, "Pera" },
                    { new Guid("ce97032e-e752-4924-9bae-3e07cd833115"), 30, 14, "Maça" }
                });
        }
    }
}
