using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarDoze.Migrations
{
    public partial class updateOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "de2a517a-c837-4f18-bdd9-5af8c8525d7a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "215A41BD-E6D9-4A2F-97CC-0D7DCFDEB508",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a9368adc-43eb-482a-826f-d235c84ccd4f", "AQAAAAEAACcQAAAAEE93l1eSXL7jpD5Jjrghu0VN1JrsN6kR7dWOSIhDLPoF9b8GVoapwRco3KnnogCkKw==", "73c8dc64-fd11-4ad6-af72-1e799b312d92" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32986053-7EB3-4D44-9612-6AF63933353E",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "84188a5b-fc48-4d0d-8490-6e9bc7d9d0e0", "AQAAAAEAACcQAAAAEHe28I73Ubib1rOu6ySV4SBbtXOiMbTx7Kv6hDwTibnxbIxahH9m5CJhN47ZKYSHhg==", "209aec33-7925-464e-8f3e-63062216b042" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6777CE32-FBAA-4084-9EFF-A0C9290F0AFA",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d8a23614-04bc-40ed-aaea-1c5bd7c5db8c", "AQAAAAEAACcQAAAAEOwsHse5wOtpAuQwI5Qiod573J15DqOpL5YXXEZ7y9sEBH9qYKlJysRLl/oFO7HekQ==", "9e679854-68c6-4f7f-ad29-b3434ce80fae" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
