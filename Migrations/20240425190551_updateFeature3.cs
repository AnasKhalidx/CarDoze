using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarDoze.Migrations
{
    public partial class updateFeature3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "871c1cee-e907-41d8-a79f-9a0bce1f5081");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "215A41BD-E6D9-4A2F-97CC-0D7DCFDEB508",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5cd368b3-768f-408a-a2be-1d6ec89acbef", "AQAAAAEAACcQAAAAEFyZHFmN65m0zy6kOaTMSts/g3vvawwkq7ndmN/BDh6PnfwGGMnDmsztaG6KFAHz8w==", "e3de0519-c81e-404f-af1c-cd14326da18b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32986053-7EB3-4D44-9612-6AF63933353E",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b218aed6-b742-4744-bc40-15b64af360bd", "AQAAAAEAACcQAAAAECPjJeoJjuljbmID1W2ZUYc5Be+DxtmltZ8UJezGvM8Nb9qXzEyCjztfvM5MQ0DErQ==", "21298200-c988-464e-9a1b-cb8440f1a23f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6777CE32-FBAA-4084-9EFF-A0C9290F0AFA",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e1ec23bc-347f-4e7f-bc3d-de9a4c2a5930", "AQAAAAEAACcQAAAAECOgBkvz5q8Lf6iufufpnDAlxTs+2dHssu5hV+/I52wo1V5EFfZLiQsk0aHu7MUIaA==", "0815e01d-d276-482c-8ee6-cd895cbdde6d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "c181a7dc-95f0-458b-80c5-8072f98bf4a3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "215A41BD-E6D9-4A2F-97CC-0D7DCFDEB508",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "86165cd5-ed1e-4b74-959f-b59836805310", "AQAAAAEAACcQAAAAEMbNPcc1023CjG+iHqdmeobYZS4sMNt+fJqoVguBeoFXvTPV6AgzO7bAiEn+GP/PAQ==", "911ecab5-9a08-4c02-8255-20e7bc406ec5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32986053-7EB3-4D44-9612-6AF63933353E",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "79bd430e-8d0e-4be8-888f-84cdbe99df62", "AQAAAAEAACcQAAAAENbfSH8IxYibvRZiEZuozjFtE292Qf+O9K5tgEdD64YVN2C8qxFdtt+ZTf+d8Wtw/w==", "5854c2b7-d6a2-4ecf-83ba-99b3b42036d2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6777CE32-FBAA-4084-9EFF-A0C9290F0AFA",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "19b99e56-038b-46c9-a88b-701b098e308c", "AQAAAAEAACcQAAAAEHDHMmDm9dX3MYpsyynMZLlflD+91zPGORPPmDxrSgMOU3xn9J76CFc6iVgQbQbuYQ==", "72d2a84d-cc2c-43ee-8258-e69f9cc8da0a" });
        }
    }
}
