using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace e_shop.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UseSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "updated_at",
                table: "products",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "products",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "updated_at",
                table: "categories",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "categories",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "category_id", "category_description", "category_name", "created_by", "icon", "image_path", "is_active", "parent_id", "updated_by" },
                values: new object[] { 4, "All kinds of electronic items", "Cars", 2, "electronics-icon.png", "images/electronics.png", true, 2, 2 });

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "product_id", "created_by", "discount_price", "product_description", "product_name", "product_note", "product_weight", "published", "quantity", "regular_price", "sku", "short_description", "updated_by" },
                values: new object[] { 4, 2, 80.00m, "Detailed description of the product", "Banana", "Special note about the product", 1.5m, true, 10, 100.00m, "55555", "Short description of the product", 2 });

            migrationBuilder.InsertData(
                table: "product_categories",
                columns: new[] { "category_id", "product_id" },
                values: new object[] { 4, 4 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "product_categories",
                keyColumns: new[] { "category_id", "product_id" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "category_id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "product_id",
                keyValue: 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "updated_at",
                table: "products",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "products",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AlterColumn<DateTime>(
                name: "updated_at",
                table: "categories",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "categories",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "CURRENT_TIMESTAMP");
        }
    }
}
