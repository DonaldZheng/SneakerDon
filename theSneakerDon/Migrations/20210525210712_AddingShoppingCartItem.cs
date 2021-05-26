using Microsoft.EntityFrameworkCore.Migrations;

namespace theSneakerDon.Migrations
{
    public partial class AddingShoppingCartItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ShoppingCartItems",
                columns: table => new
                {
                    ShoppingCartItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShoppingCartId = table.Column<string>(nullable: true),
                    SneakerId = table.Column<int>(nullable: true),
                    Amount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartItems", x => x.ShoppingCartItemId);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems_Sneaker_SneakerId",
                        column: x => x.SneakerId,
                        principalTable: "Sneaker",
                        principalColumn: "SneakerId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Sneaker",
                keyColumn: "SneakerId",
                keyValue: 4,
                column: "IsOnSale",
                value: true);

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_SneakerId",
                table: "ShoppingCartItems",
                column: "SneakerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShoppingCartItems");

            migrationBuilder.UpdateData(
                table: "Sneaker",
                keyColumn: "SneakerId",
                keyValue: 4,
                column: "IsOnSale",
                value: false);
        }
    }
}
