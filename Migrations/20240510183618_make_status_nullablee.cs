using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarDoze.Migrations
{
    public partial class make_status_nullablee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Orders",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "8ac74ce9-6d62-42da-bbd3-bed0c73ebd51");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "215A41BD-E6D9-4A2F-97CC-0D7DCFDEB508",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d363c1ed-3ea4-4929-856a-b52bbf567ba3", "AQAAAAEAACcQAAAAEJ26eQMqLvox9V7gX30VHHDfjTtrf535CdB9Kr1MVswgzoraWOV3kxbkHgc1yO/Jmg==", "21c00478-f961-4368-af3f-990dc036ea32" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32986053-7EB3-4D44-9612-6AF63933353E",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b63910dd-23c3-48c7-a401-2a9d925a91d4", "AQAAAAEAACcQAAAAEKduEuEYGF3wzf72GHJKN9SbeoCwFghwmPHLw9cD3z/Y3bnzCXN9+uGx6iyF9a0oqg==", "cb7b2389-2f9f-4e90-bd38-1c679140dd32" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6777CE32-FBAA-4084-9EFF-A0C9290F0AFA",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a032e3c6-bc46-4edb-98cd-250ea6919165", "AQAAAAEAACcQAAAAEO4gzmTugWplccloE+tCYUg1EyiM0wUygAiepLgQY1J6nHZKsq+x59DjZOtrY/dWdA==", "ffca1b26-c438-4afa-917f-875f52cf8f93" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Orders",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

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
    }
}
