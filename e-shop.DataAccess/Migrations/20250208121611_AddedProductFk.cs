using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace e_shop.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddedProductFk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "ix_card_items_product_id",
                table: "card_items",
                column: "product_id");

            migrationBuilder.AddForeignKey(
                name: "fk_card_items_products_product_id",
                table: "card_items",
                column: "product_id",
                principalTable: "products",
                principalColumn: "product_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_card_items_products_product_id",
                table: "card_items");

            migrationBuilder.DropIndex(
                name: "ix_card_items_product_id",
                table: "card_items");
        }
    }
}
