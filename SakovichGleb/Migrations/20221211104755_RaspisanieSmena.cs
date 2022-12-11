using Microsoft.EntityFrameworkCore.Migrations;

namespace SakovichGleb.Migrations
{
    public partial class RaspisanieSmena : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Smena",
                table: "Raspisanies",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Smena",
                table: "Raspisanies");
        }
    }
}
