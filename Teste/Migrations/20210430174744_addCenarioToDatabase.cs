using Microsoft.EntityFrameworkCore.Migrations;

namespace Monstros_SA.Migrations
{
    public partial class addCenarioToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Cenario",
                table: "Personagens",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cenario",
                table: "Personagens");
        }
    }
}
