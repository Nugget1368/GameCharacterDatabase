using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameCharacterDatabase.Migrations
{
    /// <inheritdoc />
    public partial class changedBackpack : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Backpacks");

            migrationBuilder.CreateTable(
                name: "Inventorys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CharacterId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventorys", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Inventorys_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Inventorys_CharacterId",
                table: "Inventorys",
                column: "CharacterId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Inventorys");

            migrationBuilder.CreateTable(
                name: "Backpacks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CharacterId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Backpacks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Backpacks_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Backpacks_CharacterId",
                table: "Backpacks",
                column: "CharacterId",
                unique: true);
        }
    }
}
