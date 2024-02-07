using Microsoft.EntityFrameworkCore.Migrations;

namespace WellBeings_NetCoreApp.Migrations
{
    public partial class Initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Description", "Name", "Price", "ProductTypeId", "TypeId" },
                values: new object[] { 1, "Description1", "Diesel 5lb", 89.99f, null, 1 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Description", "Name", "Price", "ProductTypeId", "TypeId" },
                values: new object[] { 2, "Description2", "Progressive Collagen 600g", 49.99f, null, 2 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Description", "Name", "Price", "ProductTypeId", "TypeId" },
                values: new object[] { 3, "Description3", "Progressive Multivitamin Active Men 216 Caps", 59.99f, null, 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);
        }
    }
}
