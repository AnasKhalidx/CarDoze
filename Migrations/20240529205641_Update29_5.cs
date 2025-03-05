using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarDoze.Migrations
{
    public partial class Update29_5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "3bf84e78-21c6-4dc7-92a2-5a3a8c6ebdcf");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "215A41BD-E6D9-4A2F-97CC-0D7DCFDEB508",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9a718e85-0b15-4436-8ec6-993fbffd376f", "AQAAAAEAACcQAAAAEMFEHlBxsuFu07bE9wjc9lCmM7CZb7Ufn8HK0/aW5jcrBxIg9l1lOoezaNOZSglgdQ==", "010aa242-1733-44ea-931e-b1caaf785788" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32986053-7EB3-4D44-9612-6AF63933353E",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "94bdb30a-ada4-48f0-bdd3-219591f522fb", "AQAAAAEAACcQAAAAEDDz9+QeU8pEe6hC3R88zpy7dkWpShXAB+E3lPhi6wRoPUmlMs0cxVOFpq7VoyGHvA==", "0c9b484a-f8b4-4e11-b42f-a580a36683b8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6777CE32-FBAA-4084-9EFF-A0C9290F0AFA",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ece0a99d-2ad0-4754-bcd8-988d533cd756", "AQAAAAEAACcQAAAAEPz8+FnbQl1r5P6BTGw6sy5GD1GARvimZIQK5Ewj5gHyeocsVbx6q0fEYNFIt6GRcA==", "2e816833-2b0b-49d7-915a-cf7d3e811c4b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "05b304d0-500a-41f7-840d-025d238695a9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "215A41BD-E6D9-4A2F-97CC-0D7DCFDEB508",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "25d398d1-09bd-46e6-8755-3bf447ab2770", "AQAAAAEAACcQAAAAEJgV47EN7FTRYEB3JjocuhyQ3zLTOY+aWLJ6XQuAmmSdx5Z85taRo6syuvT4kNK1pA==", "5175368e-2ba5-4918-a24a-d9d3966af7ae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32986053-7EB3-4D44-9612-6AF63933353E",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2b41fbd6-599e-4bb4-a718-155bbc320837", "AQAAAAEAACcQAAAAEFbn9x6GVXOmiIG1dGBO4njtUMLggmEzG75/bbXUI5uqljYpxrmGNYa6B4kW1JyQcQ==", "9263de86-0bc0-47dc-a184-588abc0507db" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6777CE32-FBAA-4084-9EFF-A0C9290F0AFA",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9d70795f-c06c-41c8-b83d-423331c844bc", "AQAAAAEAACcQAAAAEOOatSuTzoX0rFXGflnBXjoZ4KUTnjtMTwN8nDT/Y+mCAFqR/f0ODvgDvkJSxiXTJw==", "15afc5d8-16b8-4cec-a13f-ce94ddb58aba" });
        }
    }
}
