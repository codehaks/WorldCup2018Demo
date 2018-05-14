using Microsoft.EntityFrameworkCore.Migrations;

namespace WroldCupDemo.Migrations
{
    public partial class SeedTeamData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "Appearances", "Group", "Name", "Rank", "Titles" },
                values: new object[] { 1, 4, "B", "Iran", 32, 0 });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "Appearances", "Group", "Name", "Rank", "Titles" },
                values: new object[] { 2, 4, "B", "Morocco", 40, 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
