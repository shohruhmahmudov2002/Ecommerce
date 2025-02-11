using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace e_shop.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ModelCreating : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "sku",
                table: "products",
                type: "character varying(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<decimal>(
                name: "regular_price",
                table: "products",
                type: "numeric",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AlterColumn<bool>(
                name: "is_active",
                table: "categories",
                type: "boolean",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AlterColumn<string>(
                name: "category_name",
                table: "categories",
                type: "character varying(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.CreateTable(
                name: "product_category",
                columns: table => new
                {
                    category_id = table.Column<int>(type: "integer", nullable: false),
                    product_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_product_category", x => new { x.product_id, x.category_id });
                    table.ForeignKey(
                        name: "fk_product_category_categories_category_id",
                        column: x => x.category_id,
                        principalTable: "categories",
                        principalColumn: "category_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_product_category_products_product_id",
                        column: x => x.product_id,
                        principalTable: "products",
                        principalColumn: "product_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "ix_product_category_category_id",
                table: "product_category",
                column: "category_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "product_category");

            migrationBuilder.AlterColumn<string>(
                name: "sku",
                table: "products",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<decimal>(
                name: "regular_price",
                table: "products",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric",
                oldDefaultValue: 0m);

            migrationBuilder.AlterColumn<bool>(
                name: "is_active",
                table: "categories",
                type: "boolean",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "boolean",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<string>(
                name: "category_name",
                table: "categories",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(255)",
                oldMaxLength: 255);
        }
    }
}
