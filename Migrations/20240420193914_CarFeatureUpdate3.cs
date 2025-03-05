using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarDoze.Migrations
{
    public partial class CarFeatureUpdate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarFeatures_Cars_CarID",
                table: "CarFeatures");

            migrationBuilder.DropIndex(
                name: "IX_CarFeatures_CarID",
                table: "CarFeatures");

            migrationBuilder.DropColumn(
                name: "CarID",
                table: "CarFeatures");

            migrationBuilder.CreateTable(
                name: "CarCarFeatures",
                columns: table => new
                {
                    CarFeaturesCarFeatureID = table.Column<int>(type: "int", nullable: false),
                    CarsCarID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarCarFeatures", x => new { x.CarFeaturesCarFeatureID, x.CarsCarID });
                    table.ForeignKey(
                        name: "FK_CarCarFeatures_CarFeatures_CarFeaturesCarFeatureID",
                        column: x => x.CarFeaturesCarFeatureID,
                        principalTable: "CarFeatures",
                        principalColumn: "CarFeatureID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarCarFeatures_Cars_CarsCarID",
                        column: x => x.CarsCarID,
                        principalTable: "Cars",
                        principalColumn: "CarID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "6dcd4635-1ff7-4279-bf4e-2388f82d1be3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "215A41BD-E6D9-4A2F-97CC-0D7DCFDEB508",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "50546170-e1d7-48f5-8688-6fb23428a20e", "AQAAAAEAACcQAAAAEIT2D7syYZdZxhct6xXc10GQnVPu2X2RJEQ0t+P7EySH2ufiXtXt43J/uPZ/qiNkvA==", "0b89d7c1-f710-474a-a629-ed1ad6119d61" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32986053-7EB3-4D44-9612-6AF63933353E",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cb7a45f9-aea5-4ad6-b210-8d29716793b1", "AQAAAAEAACcQAAAAEDQpNJAUNO/EPX4M1kTyV5Dq942F9Bp00SIBycofe6ogZbrvLhBFGtsVcAF3XZFMpg==", "68ef8994-c089-4fdd-af7d-3f95c7a09410" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6777CE32-FBAA-4084-9EFF-A0C9290F0AFA",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "afccc149-eaa7-451b-bbc8-56e37f25cbed", "AQAAAAEAACcQAAAAEH+DMx5Ap+WKJ2DvKhIC1D0wOcPUKTeA4pVAIWeqljdmVGfQVciJ59DMEZ+18iMkOw==", "91804f21-c9f6-4b86-9294-4e65a9b766a4" });

            migrationBuilder.CreateIndex(
                name: "IX_CarCarFeatures_CarsCarID",
                table: "CarCarFeatures",
                column: "CarsCarID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarCarFeatures");

            migrationBuilder.AddColumn<int>(
                name: "CarID",
                table: "CarFeatures",
                type: "int",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_CarFeatures_CarID",
                table: "CarFeatures",
                column: "CarID");

            migrationBuilder.AddForeignKey(
                name: "FK_CarFeatures_Cars_CarID",
                table: "CarFeatures",
                column: "CarID",
                principalTable: "Cars",
                principalColumn: "CarID");
        }
    }
}
