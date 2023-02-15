using Microsoft.EntityFrameworkCore.Migrations;

namespace UsuariosAPI.Migrations
{
    public partial class Criandoroleregular : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "188b95f0-0685-4649-9210-ddf2bf0a6064");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { 99998, "85e436b9-cd60-4f04-9c1c-b3734e6cd871", "regular", "REGULAR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b9851291-dadc-4139-9dc7-dd0f20b8fbe6", "AQAAAAEAACcQAAAAEMUyl6t8PZa5zOIKdotcQdbIjGxyVuk2KtWNLG5WmMxotyECf/h7uBaKGOvk01rsHA==", "34b1a278-f5f5-447a-85ad-a44aa658da8f" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99998);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "e0b94d2d-2af9-4fdb-a310-5a52f998ba3b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5ebbd649-0899-45a6-a7ad-7be7dd4aff45", "AQAAAAEAACcQAAAAECqfx0+efTvI1C50NJkdzBS4G7oKQhHYyVt7h4fPA+v9YPAPMNAmMtF0D3BIFS+UuQ==", "6eef1892-4914-405a-af99-3e1d9c9bbde7" });
        }
    }
}
