using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarDoze.Migrations
{
    public partial class updateFeature : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarCarFeatures_CarFeatures_CarFeatureID",
                table: "CarCarFeatures");

            migrationBuilder.RenameColumn(
                name: "CarFeatureID",
                table: "CarCarFeatures",
                newName: "FeatureID");

            migrationBuilder.RenameIndex(
                name: "IX_CarCarFeatures_CarFeatureID",
                table: "CarCarFeatures",
                newName: "IX_CarCarFeatures_FeatureID");

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

            migrationBuilder.AddForeignKey(
                name: "FK_CarCarFeatures_CarFeatures_FeatureID",
                table: "CarCarFeatures",
                column: "FeatureID",
                principalTable: "CarFeatures",
                principalColumn: "CarFeatureID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarCarFeatures_CarFeatures_FeatureID",
                table: "CarCarFeatures");

            migrationBuilder.RenameColumn(
                name: "FeatureID",
                table: "CarCarFeatures",
                newName: "CarFeatureID");

            migrationBuilder.RenameIndex(
                name: "IX_CarCarFeatures_FeatureID",
                table: "CarCarFeatures",
                newName: "IX_CarCarFeatures_CarFeatureID");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "92725ba5-5903-463a-b6c0-dc469f890035");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "215A41BD-E6D9-4A2F-97CC-0D7DCFDEB508",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d9ad8be2-c06a-4641-b04a-4200846bc199", "AQAAAAEAACcQAAAAEFW1Dwp8pZ9YB9HXQO7jdXEQqjaNpwK41hb+J8zOO5HWV3UdZFxboRQH+OwDm/6Emw==", "97ad5e04-fc27-41db-b526-f9e990b766b2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32986053-7EB3-4D44-9612-6AF63933353E",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eee25005-1473-4130-a53c-625f24a51f56", "AQAAAAEAACcQAAAAEGQfbsQN7sRqBJR6gdHWT5Baf/cdtUk0Ruvu6T7Z/U5mmyxyMg+cd7S7eeU1WOoxhg==", "34c322cf-427a-4459-9f5b-cca32d3e1d2e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6777CE32-FBAA-4084-9EFF-A0C9290F0AFA",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "89a735c0-3ed5-454a-9aa9-699f0816e992", "AQAAAAEAACcQAAAAEDqDxRPBGelR1oT5tKnPfwrQgQqxaP5Sk7U9Y+xEC0U64t0o/pl5s+iJvk19TXCqGQ==", "6eb105e4-7cd9-4580-90d4-04b4ed30eb83" });

            migrationBuilder.AddForeignKey(
                name: "FK_CarCarFeatures_CarFeatures_CarFeatureID",
                table: "CarCarFeatures",
                column: "CarFeatureID",
                principalTable: "CarFeatures",
                principalColumn: "CarFeatureID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
