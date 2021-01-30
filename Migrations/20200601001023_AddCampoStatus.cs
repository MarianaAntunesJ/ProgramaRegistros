using Microsoft.EntityFrameworkCore.Migrations;

namespace ProgramaRegistros.Migrations
{
    public partial class AddCampoStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Pessoas",
                nullable: false,
                defaultValue: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Pessoas");
        }
    }
}
