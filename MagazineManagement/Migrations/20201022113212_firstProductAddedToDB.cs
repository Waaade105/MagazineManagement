using Microsoft.EntityFrameworkCore.Migrations;

namespace MagazineManagement.Migrations
{
    public partial class firstProductAddedToDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Name", "PhotoPath", "Quantity", "Value" },
                values: new object[] { 1, 0, "Coffee", null, 156, 1.3899999999999999 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
