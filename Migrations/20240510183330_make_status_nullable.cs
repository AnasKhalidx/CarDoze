using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarDoze.Migrations
{
    public partial class make_status_nullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "6c19b9de-f8b0-4ec6-9a9c-52cde95e6983");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "215A41BD-E6D9-4A2F-97CC-0D7DCFDEB508",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "34a3dfb0-a7c6-456e-af0f-6688c4c75325", "AQAAAAEAACcQAAAAEK+GAVBAaVLR4zMMLgEtQjPZurtWn66VA/j7xAWHzBz3JTLBLhfWitKPq6bJNFDL8Q==", "19dd9f72-6559-4b8f-9ecb-aab0babc0e04" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32986053-7EB3-4D44-9612-6AF63933353E",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f0efb1d2-abaa-4d1d-8974-34b4ed027dec", "AQAAAAEAACcQAAAAEAFqyqcLcGXEShs4o6cQ5FAaRoaBrr/Mdl/ADdV/PMfswvtdDN2sRbzQTfj9DuswHQ==", "b2336bbb-e4ad-4bed-85e3-b3d2c205fb85" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6777CE32-FBAA-4084-9EFF-A0C9290F0AFA",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "442d1c92-42ad-4caa-8385-1463a41bb613", "AQAAAAEAACcQAAAAENY4nfNI99o4n7AHzeYzKbdJJjik4I95DEPIzeYrX54xY05Q/tbd6Ub3QrS59bAXQA==", "2a122fc9-11af-45d5-b4a2-f9ad0acf0f17" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "5adb2a5b-9c18-4a42-a8f9-abc559c4f090");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "215A41BD-E6D9-4A2F-97CC-0D7DCFDEB508",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d0492e21-eef9-406d-bf06-08edac183932", "AQAAAAEAACcQAAAAEITsYz6TZG3REWox1lMYpoklefFBxflKQ3Ks/yxVtmX0zNbx/v633/f3NtB2w33T0Q==", "798ac41d-0d92-4178-9898-2ad2113de401" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32986053-7EB3-4D44-9612-6AF63933353E",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7b3dff5b-b80c-4122-906b-f360e1ab512e", "AQAAAAEAACcQAAAAEMFMeqRSNNcI8+fU7oDGxTGVE/Q87UXcEf1vXU71uJkaSsSIj5tiKjJj3F2QXNQHcw==", "37f8ba22-adc9-4f61-ba57-aee62b5dd76c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6777CE32-FBAA-4084-9EFF-A0C9290F0AFA",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8b5c0759-e515-4d0d-a9dd-f28361d807e4", "AQAAAAEAACcQAAAAELv8YJP9IQiKLa3/1/bB4shPWfLtmZNwcm9Zl+bSxXLLFrV4QCSsuOMi3zFIZlxW/A==", "234b5575-0ca9-4488-9fc9-ef25c6a5dfab" });
        }
    }
}
