using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WorldCupDemo.Migrations
{
    public partial class PlayerInfoOneToOne01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlayersInfo_Players_PlayerInfoId",
                table: "PlayersInfo");

            migrationBuilder.AlterColumn<int>(
                name: "PlayerInfoId",
                table: "PlayersInfo",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "PlayerId",
                table: "PlayersInfo",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_PlayersInfo_PlayerId",
                table: "PlayersInfo",
                column: "PlayerId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PlayersInfo_Players_PlayerId",
                table: "PlayersInfo",
                column: "PlayerId",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlayersInfo_Players_PlayerId",
                table: "PlayersInfo");

            migrationBuilder.DropIndex(
                name: "IX_PlayersInfo_PlayerId",
                table: "PlayersInfo");

            migrationBuilder.DropColumn(
                name: "PlayerId",
                table: "PlayersInfo");

            migrationBuilder.AlterColumn<int>(
                name: "PlayerInfoId",
                table: "PlayersInfo",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddForeignKey(
                name: "FK_PlayersInfo_Players_PlayerInfoId",
                table: "PlayersInfo",
                column: "PlayerInfoId",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
