using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NonoGame.Migrations
{
    public partial class EditNonogram : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Size",
                table: "Nonogram",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Size",
                table: "Nonogram");
        }
    }
}
