using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarDoze.Migrations
{
    public partial class ca : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "2914770b-70f4-4dfa-9e18-110237afa19b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "215A41BD-E6D9-4A2F-97CC-0D7DCFDEB508",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "89d0df6f-7fff-493c-8788-0f5de735f463", "AQAAAAEAACcQAAAAEOsi1KrFIVwzEFj9IO6T5QwLNeI5RtUnMpax/vK5e8bvpW3lwXFieIVnPqaN2godtA==", "6a2d26f2-fc88-4416-a01c-4df23e1bdcd3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32986053-7EB3-4D44-9612-6AF63933353E",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "373dc2f6-5af3-4ce7-9582-0d17e367bd82", "AQAAAAEAACcQAAAAEL6D2ZE3hs6cztrp43fTOhu1JWuDU6qQUe1nXKVB/pQ8iif6SIejGpNihJnF6HcgYA==", "5eb1e68f-7462-439b-992c-0ca4d13abec7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6777CE32-FBAA-4084-9EFF-A0C9290F0AFA",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "55a4b3c9-9913-48cb-ad73-63abb4b4418b", "AQAAAAEAACcQAAAAEGJm5lKpR+21fxeQM4V1T43jxq6RzWQbTl0UUC4OC2cKlEXdIy8+5Z9mmrXrNqqvDA==", "12cda879-b9a6-46c6-b791-8972686f10c6" });
        }
    }
}
