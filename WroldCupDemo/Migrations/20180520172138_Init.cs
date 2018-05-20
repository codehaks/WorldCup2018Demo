using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WorldCupDemo.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PlayersInfo",
                columns: table => new
                {
                    PlayerInfoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayersInfo", x => x.PlayerInfoId);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    GroupName = table.Column<string>(nullable: true),
                    Appearances = table.Column<int>(nullable: false),
                    Titles = table.Column<byte>(nullable: false),
                    Rank = table.Column<byte>(type: "tinyint", nullable: false),
                    Finals = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Number = table.Column<int>(nullable: false),
                    TeamId = table.Column<int>(nullable: false),
                    PlayerInfoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Players_PlayersInfo_PlayerInfoId",
                        column: x => x.PlayerInfoId,
                        principalTable: "PlayersInfo",
                        principalColumn: "PlayerInfoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Players_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "Appearances", "Finals", "GroupName", "Name", "Rank", "Titles" },
                values: new object[] { 1, 4, 0, "B", "Iran", (byte)32, (byte)0 });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "Appearances", "Finals", "GroupName", "Name", "Rank", "Titles" },
                values: new object[] { 2, 4, 0, "B", "Morocco", (byte)40, (byte)0 });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Name", "Number", "PlayerInfoId", "TeamId" },
                values: new object[] { 1, "Sardar", 0, null, 1 });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Name", "Number", "PlayerInfoId", "TeamId" },
                values: new object[] { 2, "Karim", 0, null, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Players_PlayerInfoId",
                table: "Players",
                column: "PlayerInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_Players_TeamId",
                table: "Players",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_Name",
                table: "Teams",
                column: "Name",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "PlayersInfo");

            migrationBuilder.DropTable(
                name: "Teams");
        }
    }
}
