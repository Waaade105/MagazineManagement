using Microsoft.EntityFrameworkCore.Migrations;

namespace MagazineManagement.Migrations
{
    public partial class changesInProductsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "PhotoPath",
                value: "~/images/no_product.png");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Name", "PhotoPath", "Quantity", "Value" },
                values: new object[] { 2, 0, "Green Tea", "~/images/no_product.png", 53, 1.29 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "PhotoPath",
                value: null);
        }
    }
}
