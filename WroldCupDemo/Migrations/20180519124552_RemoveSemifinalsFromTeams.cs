using Microsoft.EntityFrameworkCore.Migrations;

namespace WorldCupDemo.Migrations
{
    public partial class RemoveSemifinalsFromTeams : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Semifinals",
                table: "Teams");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Semifinals",
                table: "Teams",
                nullable: false,
                defaultValue: 0);
        }
    }
}
