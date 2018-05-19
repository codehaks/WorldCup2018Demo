using Microsoft.EntityFrameworkCore.Migrations;

namespace WorldCupDemo.Migrations
{
    public partial class TeamHasManyPlayers01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Player_Teams_TeamId",
                table: "Player");

            migrationBuilder.AlterColumn<int>(
                name: "TeamId",
                table: "Player",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TeamId1",
                table: "Player",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Player_TeamId1",
                table: "Player",
                column: "TeamId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Player_Teams_TeamId",
                table: "Player",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Player_Teams_TeamId1",
                table: "Player",
                column: "TeamId1",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Player_Teams_TeamId",
                table: "Player");

            migrationBuilder.DropForeignKey(
                name: "FK_Player_Teams_TeamId1",
                table: "Player");

            migrationBuilder.DropIndex(
                name: "IX_Player_TeamId1",
                table: "Player");

            migrationBuilder.DropColumn(
                name: "TeamId1",
                table: "Player");

            migrationBuilder.AlterColumn<int>(
                name: "TeamId",
                table: "Player",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Player_Teams_TeamId",
                table: "Player",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
