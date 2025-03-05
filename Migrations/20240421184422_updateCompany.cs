using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarDoze.Migrations
{
    public partial class updateCompany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CarCarFeatures",
                table: "CarCarFeatures");

            migrationBuilder.DropIndex(
                name: "IX_CarCarFeatures_CarID",
                table: "CarCarFeatures");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Logo",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CarCarFeatures",
                table: "CarCarFeatures",
                columns: new[] { "CarID", "CarFeatureID" });

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

            migrationBuilder.CreateIndex(
                name: "IX_CarCarFeatures_CarFeatureID",
                table: "CarCarFeatures",
                column: "CarFeatureID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CarCarFeatures",
                table: "CarCarFeatures");

            migrationBuilder.DropIndex(
                name: "IX_CarCarFeatures_CarFeatureID",
                table: "CarCarFeatures");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "Logo",
                table: "Companies");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CarCarFeatures",
                table: "CarCarFeatures",
                columns: new[] { "CarFeatureID", "CarID" });

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

            migrationBuilder.CreateIndex(
                name: "IX_CarCarFeatures_CarID",
                table: "CarCarFeatures",
                column: "CarID");
        }
    }
}
