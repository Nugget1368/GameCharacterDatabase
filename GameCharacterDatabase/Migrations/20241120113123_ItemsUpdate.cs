using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameCharacterDatabase.Migrations
{
    /// <inheritdoc />
    public partial class ItemsUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Inventorys_InventoryId",
                table: "Items");

            migrationBuilder.AlterColumn<int>(
                name: "InventoryId",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Inventorys_InventoryId",
                table: "Items",
                column: "InventoryId",
                principalTable: "Inventorys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Inventorys_InventoryId",
                table: "Items");

            migrationBuilder.AlterColumn<int>(
                name: "InventoryId",
                table: "Items",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Inventorys_InventoryId",
                table: "Items",
                column: "InventoryId",
                principalTable: "Inventorys",
                principalColumn: "Id");
        }
    }
}
