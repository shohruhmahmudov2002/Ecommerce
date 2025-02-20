using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace e_shop.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Migration3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_category_product_products_product_id",
                table: "category_product");

            migrationBuilder.RenameColumn(
                name: "product_id",
                table: "category_product",
                newName: "products_product_id");

            migrationBuilder.RenameIndex(
                name: "ix_category_product_product_id",
                table: "category_product",
                newName: "ix_category_product_products_product_id");

            migrationBuilder.AddForeignKey(
                name: "fk_category_product_products_products_product_id",
                table: "category_product",
                column: "products_product_id",
                principalTable: "products",
                principalColumn: "product_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_category_product_products_products_product_id",
                table: "category_product");

            migrationBuilder.RenameColumn(
                name: "products_product_id",
                table: "category_product",
                newName: "product_id");

            migrationBuilder.RenameIndex(
                name: "ix_category_product_products_product_id",
                table: "category_product",
                newName: "ix_category_product_product_id");

            migrationBuilder.AddForeignKey(
                name: "fk_category_product_products_product_id",
                table: "category_product",
                column: "product_id",
                principalTable: "products",
                principalColumn: "product_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
