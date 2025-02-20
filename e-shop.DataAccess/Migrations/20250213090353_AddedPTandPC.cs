using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace e_shop.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddedPTandPC : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_product_category_categories_category_id",
                table: "product_category");

            migrationBuilder.DropForeignKey(
                name: "fk_product_category_products_product_id",
                table: "product_category");

            migrationBuilder.DropForeignKey(
                name: "fk_product_tag_products_product_id",
                table: "product_tag");

            migrationBuilder.DropForeignKey(
                name: "fk_product_tag_tags_tag_id",
                table: "product_tag");

            migrationBuilder.DropPrimaryKey(
                name: "pk_product_tag",
                table: "product_tag");

            migrationBuilder.DropPrimaryKey(
                name: "pk_product_category",
                table: "product_category");

            migrationBuilder.RenameTable(
                name: "product_tag",
                newName: "product_tags");

            migrationBuilder.RenameTable(
                name: "product_category",
                newName: "product_categories");

            migrationBuilder.RenameIndex(
                name: "ix_product_tag_tag_id",
                table: "product_tags",
                newName: "ix_product_tags_tag_id");

            migrationBuilder.RenameIndex(
                name: "ix_product_category_category_id",
                table: "product_categories",
                newName: "ix_product_categories_category_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_product_tags",
                table: "product_tags",
                columns: new[] { "product_id", "tag_id" });

            migrationBuilder.AddPrimaryKey(
                name: "pk_product_categories",
                table: "product_categories",
                columns: new[] { "product_id", "category_id" });

            migrationBuilder.AddForeignKey(
                name: "fk_product_categories_categories_category_id",
                table: "product_categories",
                column: "category_id",
                principalTable: "categories",
                principalColumn: "category_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_product_categories_products_product_id",
                table: "product_categories",
                column: "product_id",
                principalTable: "products",
                principalColumn: "product_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_product_tags_products_product_id",
                table: "product_tags",
                column: "product_id",
                principalTable: "products",
                principalColumn: "product_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_product_tags_tags_tag_id",
                table: "product_tags",
                column: "tag_id",
                principalTable: "tags",
                principalColumn: "tag_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_product_categories_categories_category_id",
                table: "product_categories");

            migrationBuilder.DropForeignKey(
                name: "fk_product_categories_products_product_id",
                table: "product_categories");

            migrationBuilder.DropForeignKey(
                name: "fk_product_tags_products_product_id",
                table: "product_tags");

            migrationBuilder.DropForeignKey(
                name: "fk_product_tags_tags_tag_id",
                table: "product_tags");

            migrationBuilder.DropPrimaryKey(
                name: "pk_product_tags",
                table: "product_tags");

            migrationBuilder.DropPrimaryKey(
                name: "pk_product_categories",
                table: "product_categories");

            migrationBuilder.RenameTable(
                name: "product_tags",
                newName: "product_tag");

            migrationBuilder.RenameTable(
                name: "product_categories",
                newName: "product_category");

            migrationBuilder.RenameIndex(
                name: "ix_product_tags_tag_id",
                table: "product_tag",
                newName: "ix_product_tag_tag_id");

            migrationBuilder.RenameIndex(
                name: "ix_product_categories_category_id",
                table: "product_category",
                newName: "ix_product_category_category_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_product_tag",
                table: "product_tag",
                columns: new[] { "product_id", "tag_id" });

            migrationBuilder.AddPrimaryKey(
                name: "pk_product_category",
                table: "product_category",
                columns: new[] { "product_id", "category_id" });

            migrationBuilder.AddForeignKey(
                name: "fk_product_category_categories_category_id",
                table: "product_category",
                column: "category_id",
                principalTable: "categories",
                principalColumn: "category_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_product_category_products_product_id",
                table: "product_category",
                column: "product_id",
                principalTable: "products",
                principalColumn: "product_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_product_tag_products_product_id",
                table: "product_tag",
                column: "product_id",
                principalTable: "products",
                principalColumn: "product_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_product_tag_tags_tag_id",
                table: "product_tag",
                column: "tag_id",
                principalTable: "tags",
                principalColumn: "tag_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
