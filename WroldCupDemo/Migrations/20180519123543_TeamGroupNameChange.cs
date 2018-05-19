using Microsoft.EntityFrameworkCore.Migrations;

namespace WorldCupDemo.Migrations
{
    public partial class TeamGroupNameChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Group",
                table: "Teams",
                newName: "GroupName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GroupName",
                table: "Teams",
                newName: "Group");
        }
    }
}
