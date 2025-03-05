using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarDoze.Migrations
{
    public partial class CarFeatureUpdate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarFeatures_Cars_CarID",
                table: "CarFeatures");

            migrationBuilder.AlterColumn<int>(
                name: "CarID",
                table: "CarFeatures",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "1068d745-c286-4c87-a15e-ed35859bd4b7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "215A41BD-E6D9-4A2F-97CC-0D7DCFDEB508",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "48dffa5b-25d5-4ce9-913c-10d481c6a036", "AQAAAAEAACcQAAAAEPL3zLeQKSZPRcxxO52MO6PVIRVwUTO1f1w3g/mi132AC/QUSl07OGUlIJiDO18m9w==", "bce7e0ab-540b-4503-9789-9973197792dd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32986053-7EB3-4D44-9612-6AF63933353E",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e9a02a32-604c-4c35-9801-ce4802aa5760", "AQAAAAEAACcQAAAAECFc0MxFnfqZh0v4f/8tEx2YF5QfqszuseufGjDas3Kc0U4ihwJrgzt/cR7LQDLwQQ==", "dfc2c6ed-5108-467c-bcee-5d394cb248df" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6777CE32-FBAA-4084-9EFF-A0C9290F0AFA",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "55659c48-c9a2-4526-a2ab-f67732e70441", "AQAAAAEAACcQAAAAECOsSm1edgmDnkopluViuBOS8zcD3BI2YfknMU14XU24Q6huAwGMYJie48PXlV+a8A==", "0605d5c2-5280-4e24-9c43-19b11a11e256" });

            migrationBuilder.AddForeignKey(
                name: "FK_CarFeatures_Cars_CarID",
                table: "CarFeatures",
                column: "CarID",
                principalTable: "Cars",
                principalColumn: "CarID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarFeatures_Cars_CarID",
                table: "CarFeatures");

            migrationBuilder.AlterColumn<int>(
                name: "CarID",
                table: "CarFeatures",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "2eb7ac43-6233-47b9-ab1c-343ee5cd8d19");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "215A41BD-E6D9-4A2F-97CC-0D7DCFDEB508",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1835a14c-4e66-4797-acba-90e5379dbd2f", "AQAAAAEAACcQAAAAEB5+GEVS7Y5eMY7hWX+sKq+Io3s+ku22s623H3Q+t/JbHSpScY8GJXET+XFtx5Lfww==", "176cd6c1-7b02-4412-8653-a5d5f6508e6a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32986053-7EB3-4D44-9612-6AF63933353E",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "df022202-db68-46ba-9f7a-1a068ba03468", "AQAAAAEAACcQAAAAEOvDSETR9HGvT+EE/Drkkz/+zwTjipCdy9/5k3lOw5Y22OxKzvi/SQJ/TO+L61MHHQ==", "d32d5156-5935-4c71-9cf8-66aaf276643a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6777CE32-FBAA-4084-9EFF-A0C9290F0AFA",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "133ae607-0a8d-49d1-bf5f-7540539efb32", "AQAAAAEAACcQAAAAEJv7yoD43PY8eIa1gxPJizyB2iyIT8jPM6HACUzLN4gbGez178Avx3oDYbRShzgjYA==", "dc0b7d2d-cbf0-4f61-8661-cc2b2b39d010" });

            migrationBuilder.AddForeignKey(
                name: "FK_CarFeatures_Cars_CarID",
                table: "CarFeatures",
                column: "CarID",
                principalTable: "Cars",
                principalColumn: "CarID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
