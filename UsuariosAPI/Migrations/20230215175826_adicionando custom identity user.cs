using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UsuariosAPI.Migrations
{
    public partial class adicionandocustomidentityuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataNascimento",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99998,
                column: "ConcurrencyStamp",
                value: "4d8a5a54-be06-46e9-aea5-895f4133ea40");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "8272bd9f-5a14-4cc5-bd4c-8b4f8cc31994");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7c407bbd-f50a-40b8-a2d8-97b533d8d985", "AQAAAAEAACcQAAAAEHrtzCIXiOO6zFn9KbGO1otiExW/tZtuc5RkvvL/4j0Y7vmZfJbG49vESQ/BZQBbLw==", "651a1888-bc7e-47e9-9ae1-15c7e5f00d15" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataNascimento",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99998,
                column: "ConcurrencyStamp",
                value: "4945ccd4-96bf-45db-bdf5-f58738394120");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "8ccfb3f5-eba6-41ed-b43f-bfa071c4d604");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c6207334-6136-41e0-bda9-144209164226", "AQAAAAEAACcQAAAAENKop/YwE6f0DzWlFUnu9s15cJQWLUz6f1TSnweAxgU/qHkYZoxd9l3Tk/8MOHGIIQ==", "fdca2d3d-b954-43ec-9a05-5b011ba6aa62" });
        }
    }
}
