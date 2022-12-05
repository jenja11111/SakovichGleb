using Microsoft.EntityFrameworkCore.Migrations;

namespace SakovichGleb.Migrations
{
    public partial class Raspisanie1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Day",
                table: "Raspisanies",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Day",
                table: "Raspisanies");
        }
    }
}
