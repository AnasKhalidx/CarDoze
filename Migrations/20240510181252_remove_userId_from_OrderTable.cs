using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarDoze.Migrations
{
    public partial class remove_userId_from_OrderTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_UserId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_UserId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "d1a16f49-9f5c-4914-a38b-f8b57077f6a7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "215A41BD-E6D9-4A2F-97CC-0D7DCFDEB508",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0b85e2df-bf84-40af-9992-dd7813097276", "AQAAAAEAACcQAAAAEBjCciWu4L3mNGGI34h4LllnezAWAhEsxl4RBp5p6Bi5Fl52+loreeC2+dm3usNAMQ==", "9b76fab6-42a3-4270-994b-9b91d3f5ba9f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32986053-7EB3-4D44-9612-6AF63933353E",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ab7a368d-9392-4aa7-8e3c-7d750e091a6e", "AQAAAAEAACcQAAAAEAoIbyamUrpru3G8AXcrYj4jigq5ZrkCulyLB1FxPM/Rqnv9AxwgJTO8+KDcPSWUZQ==", "a5a50022-69eb-4efd-9700-7e6b6c2f171e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6777CE32-FBAA-4084-9EFF-A0C9290F0AFA",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d701931c-72b3-4a96-988e-ca3c35481644", "AQAAAAEAACcQAAAAEILbwtp7UMcjN210l9AVAHg17H0BFtUZnk5/wbAObKo+Psei7osJ7R702rAHI8/dcg==", "b81790f8-d31f-4efb-a142-233c03c4b2b6" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Orders",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

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

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_UserId",
                table: "Orders",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
