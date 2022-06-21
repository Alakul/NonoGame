using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NonoGame.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Nonogram",
                columns: new[] { "Id", "Date", "Image", "Size" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 6, 21, 18, 19, 22, 873, DateTimeKind.Local).AddTicks(6321), "0;1;1;1;0;0;0;0;1;1;1;1;1;1;1;1;1;0;0;0;0;1;1;1;0", 5 },
                    { 2, new DateTime(2022, 6, 21, 18, 19, 22, 873, DateTimeKind.Local).AddTicks(6354), "1;1;1;1;0;0;1;0;0;0;0;1;1;0;0;0;1;0;0;1;1;1;1;1;0", 5 },
                    { 3, new DateTime(2022, 6, 21, 18, 19, 22, 873, DateTimeKind.Local).AddTicks(6357), "0;1;1;1;1;0;1;0;0;1;0;1;0;0;1;1;1;0;1;1;1;1;0;1;1", 5 },
                    { 4, new DateTime(2022, 6, 21, 18, 19, 22, 873, DateTimeKind.Local).AddTicks(6359), "1;0;0;1;0;0;1;0;1;1;1;1;1;0;0;1;0;0;0;1;0;0;1;0;1;0;1;0;0;1;0;0;0;1;0;0;1;1;1;1;1;0;1;0;0;1;0;0;1", 7 },
                    { 5, new DateTime(2022, 6, 21, 18, 19, 22, 873, DateTimeKind.Local).AddTicks(6361), "0;0;1;0;0;0;0;1;0;0;1;1;1;1;1;0;1;1;1;0;1;0;0;0;1", 5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Nonogram",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Nonogram",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Nonogram",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Nonogram",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Nonogram",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
