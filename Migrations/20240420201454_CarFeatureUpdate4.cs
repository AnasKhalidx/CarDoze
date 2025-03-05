using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarDoze.Migrations
{
    public partial class CarFeatureUpdate4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarCarFeatures_CarFeatures_CarFeaturesCarFeatureID",
                table: "CarCarFeatures");

            migrationBuilder.DropForeignKey(
                name: "FK_CarCarFeatures_Cars_CarsCarID",
                table: "CarCarFeatures");

            migrationBuilder.RenameColumn(
                name: "CarsCarID",
                table: "CarCarFeatures",
                newName: "CarID");

            migrationBuilder.RenameColumn(
                name: "CarFeaturesCarFeatureID",
                table: "CarCarFeatures",
                newName: "CarFeatureID");

            migrationBuilder.RenameIndex(
                name: "IX_CarCarFeatures_CarsCarID",
                table: "CarCarFeatures",
                newName: "IX_CarCarFeatures_CarID");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "4aa140f7-df57-472b-afab-de5b1eb987ae");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "215A41BD-E6D9-4A2F-97CC-0D7DCFDEB508",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a49cf8bb-950a-403f-9876-4b0e5f873a77", "AQAAAAEAACcQAAAAEJZvkwB0bgFsnyGh+WwjJ1s5DMWjReQ6E/sk09Eb6PetB5B6++g9hZ3bvOYqaRkjnA==", "6b85fb42-58e7-42f3-850b-f61f62b939fb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32986053-7EB3-4D44-9612-6AF63933353E",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a24e1d4d-97b5-4c3d-9342-46380bb9d6b7", "AQAAAAEAACcQAAAAENeQCKgR3HsHE0hXsLvA5Kv9lZmEkBMJ+3xz9D85W76B8qdNFqfTYTuN6QoE+5PjDA==", "c858b51a-ca0a-419e-b468-e986c32dd4b2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6777CE32-FBAA-4084-9EFF-A0C9290F0AFA",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1698d036-1560-4fc8-b1dc-82c6c2844503", "AQAAAAEAACcQAAAAEFPme3pCztXEsRadWxmxHUmYMJMiVUyYQCmyjehkEXd8uzhB91rMoCL+KoBDLOQNzw==", "52f18662-df66-4a7e-90eb-e88f61c2e5a5" });

            migrationBuilder.AddForeignKey(
                name: "FK_CarCarFeatures_CarFeatures_CarFeatureID",
                table: "CarCarFeatures",
                column: "CarFeatureID",
                principalTable: "CarFeatures",
                principalColumn: "CarFeatureID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CarCarFeatures_Cars_CarID",
                table: "CarCarFeatures",
                column: "CarID",
                principalTable: "Cars",
                principalColumn: "CarID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarCarFeatures_CarFeatures_CarFeatureID",
                table: "CarCarFeatures");

            migrationBuilder.DropForeignKey(
                name: "FK_CarCarFeatures_Cars_CarID",
                table: "CarCarFeatures");

            migrationBuilder.RenameColumn(
                name: "CarID",
                table: "CarCarFeatures",
                newName: "CarsCarID");

            migrationBuilder.RenameColumn(
                name: "CarFeatureID",
                table: "CarCarFeatures",
                newName: "CarFeaturesCarFeatureID");

            migrationBuilder.RenameIndex(
                name: "IX_CarCarFeatures_CarID",
                table: "CarCarFeatures",
                newName: "IX_CarCarFeatures_CarsCarID");

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

            migrationBuilder.AddForeignKey(
                name: "FK_CarCarFeatures_CarFeatures_CarFeaturesCarFeatureID",
                table: "CarCarFeatures",
                column: "CarFeaturesCarFeatureID",
                principalTable: "CarFeatures",
                principalColumn: "CarFeatureID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CarCarFeatures_Cars_CarsCarID",
                table: "CarCarFeatures",
                column: "CarsCarID",
                principalTable: "Cars",
                principalColumn: "CarID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
