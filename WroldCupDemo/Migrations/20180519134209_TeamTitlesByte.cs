using Microsoft.EntityFrameworkCore.Migrations;

namespace WorldCupDemo.Migrations
{
    public partial class TeamTitlesByte : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte>(
                name: "Titles",
                table: "Teams",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "GroupName",
                table: "Teams",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TINYTEXT",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1,
                column: "Titles",
                value: (byte)0);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2,
                column: "Titles",
                value: (byte)0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Titles",
                table: "Teams",
                nullable: false,
                oldClrType: typeof(byte));

            migrationBuilder.AlterColumn<string>(
                name: "GroupName",
                table: "Teams",
                type: "TINYTEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1,
                column: "Titles",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2,
                column: "Titles",
                value: 0);
        }
    }
}
