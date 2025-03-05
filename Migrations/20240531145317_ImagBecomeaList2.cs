using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarDoze.Migrations
{
    public partial class ImagBecomeaList2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "86127534-17a3-4cff-802d-b3db909f1fc6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "215A41BD-E6D9-4A2F-97CC-0D7DCFDEB508",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a947dac6-920b-4ff8-95de-33edca0fc2b4", "AQAAAAEAACcQAAAAEFXBq2bp9IcZb4xtr09krYlc4nUHzqZxFDggRZXOmOlCo47OjWw4/bt80N6Fy2OqTA==", "9ac56292-d1c5-46b1-8acf-8311603314cf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32986053-7EB3-4D44-9612-6AF63933353E",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "74285ec7-e083-4f8b-848b-6a6685c420de", "AQAAAAEAACcQAAAAEGT7Ls22HjEbt0hxWKgB595NobaOQV1EhJsQq2M0sMi7Mrh6TCJ02HcaQ+X04EmG4w==", "d57ec512-4c07-4b2b-98e9-466185a564a4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6777CE32-FBAA-4084-9EFF-A0C9290F0AFA",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "433a1471-faae-4e67-8a8e-3a902ad9afe5", "AQAAAAEAACcQAAAAEPKW1djwYDFV98rfbstfsWwvl2IargW2Bgo0SP8HqgSc4nd6oRO97DoXveh+2G1msg==", "369c09fd-ef5c-4861-a1ad-152f1916b781" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "5011f91b-8e13-4c51-ab65-aa34c9a74ebd");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "215A41BD-E6D9-4A2F-97CC-0D7DCFDEB508",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a1a19d2d-3815-42ce-946b-3c9c8a760caf", "AQAAAAEAACcQAAAAEBoucemMduhlOKswJTYUE0VA7ZKxPyOPNu+/y1RSERoJyu6oX14Pq7sJOTBAdgxwSA==", "462dfec1-fc9a-4ef0-b1e1-987997a75f7a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32986053-7EB3-4D44-9612-6AF63933353E",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e071821a-b2fb-4e09-934c-c8a803488900", "AQAAAAEAACcQAAAAELdloLiSmFIJV/mdm6UM/a19dWykPMf9Jg7sxK99eKF01/FjooBR3cofQESAikdhlw==", "64d05600-e928-46d9-b62e-3379b4b18861" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6777CE32-FBAA-4084-9EFF-A0C9290F0AFA",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "604a3c57-9526-4e77-bf73-ce63a57e3dd8", "AQAAAAEAACcQAAAAELVFvGtNXO+oKuGtPBrScqybwq3Qwgy0J+D6VFL4sXGXjg7Vum460z0R9nc7Wd2R4g==", "17c61255-a395-450d-9507-ce0397a6508d" });
        }
    }
}
