using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarDoze.Migrations
{
    public partial class uuu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "d65b7cc1-e14c-4c5c-9bdc-21ee14e8d216");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "215A41BD-E6D9-4A2F-97CC-0D7DCFDEB508",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b99e5fea-766a-4405-a2a2-12c611296a79", "AQAAAAEAACcQAAAAEFG9+aAnrfcZQtonUNFHMEqE0BRcqJInmV4qteQAwnpGLP0mPLx/ste34xbDdwHg7A==", "c1142fa0-45e1-4eb9-925f-aee16439c81d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32986053-7EB3-4D44-9612-6AF63933353E",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "25d617f9-dfb2-4574-a205-167ba6840a0b", "AQAAAAEAACcQAAAAEILgxNIasvwkebi8nEi7vZrEXW5CmHv45kExRmY7pdTPe7oQuCqGsE25lCfIOIQZdA==", "130327e1-b173-496d-9c42-e9505389a016" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6777CE32-FBAA-4084-9EFF-A0C9290F0AFA",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9057c68e-d169-45cf-aa9b-efa26e3aee70", "AQAAAAEAACcQAAAAEAy22CSxJsPL8GDa1jaEXsS/QpdAOWXoHN3ig14VfhmMkjuD65PazVV6lYgqHSBcrw==", "043e98ee-0ac7-48e4-a0ff-ba75267ff9e7" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
