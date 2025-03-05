using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarDoze.Migrations
{
    public partial class updateFeature2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FeatureName",
                table: "CarCarFeatures",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FeatureName",
                table: "CarCarFeatures");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "536029a0-e525-4a9c-965e-ed6f33b0f67c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "215A41BD-E6D9-4A2F-97CC-0D7DCFDEB508",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d97f8a1e-3382-4649-9915-da6f5b75045b", "AQAAAAEAACcQAAAAEM7xqGZ09QKFbbSR0I2OLdwK0eiM1I5Ju6/ORtjZi8x19bJOaZEEghZkemGYT072DQ==", "9d3ebe38-5fc7-41c0-9319-8bb5dec081cb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32986053-7EB3-4D44-9612-6AF63933353E",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c053af71-1e56-4c4c-a4a5-966950b6e0b4", "AQAAAAEAACcQAAAAEI05cZPAGg8K7DHilDkD8TFSR63PWWXYpgJ51HIox4IujCUJ9YB/b9ue92m4/l91Iw==", "f24ae21e-4863-46df-8f66-7012ee7a000b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6777CE32-FBAA-4084-9EFF-A0C9290F0AFA",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "69f5b38b-5296-4758-9015-931ef1d3a537", "AQAAAAEAACcQAAAAEGqDYooUpixYfnWWlU2zyhRWLd2t56FuBGnwdbJJOQ00H0fe2bK/QW8oMECluXayBA==", "31e15cc8-31da-4042-b7ed-eb6625a4ffe7" });
        }
    }
}
