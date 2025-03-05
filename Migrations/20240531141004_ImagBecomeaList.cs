using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarDoze.Migrations
{
    public partial class ImagBecomeaList : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "de2a517a-c837-4f18-bdd9-5af8c8525d7a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "215A41BD-E6D9-4A2F-97CC-0D7DCFDEB508",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a9368adc-43eb-482a-826f-d235c84ccd4f", "AQAAAAEAACcQAAAAEE93l1eSXL7jpD5Jjrghu0VN1JrsN6kR7dWOSIhDLPoF9b8GVoapwRco3KnnogCkKw==", "73c8dc64-fd11-4ad6-af72-1e799b312d92" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32986053-7EB3-4D44-9612-6AF63933353E",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "84188a5b-fc48-4d0d-8490-6e9bc7d9d0e0", "AQAAAAEAACcQAAAAEHe28I73Ubib1rOu6ySV4SBbtXOiMbTx7Kv6hDwTibnxbIxahH9m5CJhN47ZKYSHhg==", "209aec33-7925-464e-8f3e-63062216b042" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6777CE32-FBAA-4084-9EFF-A0C9290F0AFA",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d8a23614-04bc-40ed-aaea-1c5bd7c5db8c", "AQAAAAEAACcQAAAAEOwsHse5wOtpAuQwI5Qiod573J15DqOpL5YXXEZ7y9sEBH9qYKlJysRLl/oFO7HekQ==", "9e679854-68c6-4f7f-ad29-b3434ce80fae" });
        }
    }
}
