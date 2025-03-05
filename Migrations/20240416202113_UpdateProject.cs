using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarDoze.Migrations
{
    public partial class UpdateProject : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "isDelete",
                table: "Wishlists",
                newName: "IsDelete");

            migrationBuilder.RenameColumn(
                name: "isActive",
                table: "Wishlists",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "ModifedOn",
                table: "Wishlists",
                newName: "ModifiedOn");

            migrationBuilder.RenameColumn(
                name: "isDelete",
                table: "Reviews",
                newName: "IsDelete");

            migrationBuilder.RenameColumn(
                name: "isActive",
                table: "Reviews",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "ModifedOn",
                table: "Reviews",
                newName: "ModifiedOn");

            migrationBuilder.RenameColumn(
                name: "isDelete",
                table: "Partnerships",
                newName: "IsDelete");

            migrationBuilder.RenameColumn(
                name: "isActive",
                table: "Partnerships",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "ModifedOn",
                table: "Partnerships",
                newName: "ModifiedOn");

            migrationBuilder.RenameColumn(
                name: "isDelete",
                table: "Orders",
                newName: "IsDelete");

            migrationBuilder.RenameColumn(
                name: "isActive",
                table: "Orders",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "ModifedOn",
                table: "Orders",
                newName: "ModifiedOn");

            migrationBuilder.RenameColumn(
                name: "isDelete",
                table: "Notifications",
                newName: "IsDelete");

            migrationBuilder.RenameColumn(
                name: "isActive",
                table: "Notifications",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "ModifedOn",
                table: "Notifications",
                newName: "ModifiedOn");

            migrationBuilder.RenameColumn(
                name: "isDelete",
                table: "Manufacturers",
                newName: "IsDelete");

            migrationBuilder.RenameColumn(
                name: "isActive",
                table: "Manufacturers",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "ModifedOn",
                table: "Manufacturers",
                newName: "ModifiedOn");

            migrationBuilder.RenameColumn(
                name: "isDelete",
                table: "CompareCars",
                newName: "IsDelete");

            migrationBuilder.RenameColumn(
                name: "isActive",
                table: "CompareCars",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "ModifedOn",
                table: "CompareCars",
                newName: "ModifiedOn");

            migrationBuilder.RenameColumn(
                name: "isDelete",
                table: "Companies",
                newName: "IsDelete");

            migrationBuilder.RenameColumn(
                name: "isActive",
                table: "Companies",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "ModifedOn",
                table: "Companies",
                newName: "ModifiedOn");

            migrationBuilder.RenameColumn(
                name: "isDelete",
                table: "Cars",
                newName: "IsDelete");

            migrationBuilder.RenameColumn(
                name: "isActive",
                table: "Cars",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "ModifedOn",
                table: "Cars",
                newName: "ModifiedOn");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "CarFeatures",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "CarFeatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "CarFeatures",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "CarFeatures",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "CarFeatures",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedOn",
                table: "CarFeatures",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "39bd39a2-e04e-4e16-a155-fcf84c7e0f8c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "215A41BD-E6D9-4A2F-97CC-0D7DCFDEB508",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "86a479f9-54cd-48be-aea7-39bb31d4b93e", "AQAAAAEAACcQAAAAEMeFzi1djm1T6IMlBR8UvfasvUNYeXp2y1q46hVnAtjU/ffhfb/hYVDgYqZSZ+NtsA==", "ebce55f5-92e6-4c66-a77f-b2d0a874686b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32986053-7EB3-4D44-9612-6AF63933353E",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1b5b35f3-ec08-4c4f-a19e-457a8dc5ce43", "AQAAAAEAACcQAAAAEPAjJvgrJ7xCoUyPiypW1gY9hvmJwI+HOM6eUH2y5sSIu795SK0WA6ftsQc7MEMYog==", "37c467f4-db62-4338-9707-df0befbea26d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6777CE32-FBAA-4084-9EFF-A0C9290F0AFA",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5710e424-f5cf-481f-9ba5-8dd456dd26bd", "AQAAAAEAACcQAAAAEK5pPtr7x1k5TE1V9wzv6Z9ErXBMZgbHDHfT0Fg6foELwhCQFwPWI2NtTrSQ0mmkkg==", "d09a3b0d-6859-457e-8cf6-8feca1ef082a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "CarFeatures");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "CarFeatures");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "CarFeatures");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "CarFeatures");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "CarFeatures");

            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                table: "CarFeatures");

            migrationBuilder.RenameColumn(
                name: "IsDelete",
                table: "Wishlists",
                newName: "isDelete");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "Wishlists",
                newName: "isActive");

            migrationBuilder.RenameColumn(
                name: "ModifiedOn",
                table: "Wishlists",
                newName: "ModifedOn");

            migrationBuilder.RenameColumn(
                name: "IsDelete",
                table: "Reviews",
                newName: "isDelete");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "Reviews",
                newName: "isActive");

            migrationBuilder.RenameColumn(
                name: "ModifiedOn",
                table: "Reviews",
                newName: "ModifedOn");

            migrationBuilder.RenameColumn(
                name: "IsDelete",
                table: "Partnerships",
                newName: "isDelete");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "Partnerships",
                newName: "isActive");

            migrationBuilder.RenameColumn(
                name: "ModifiedOn",
                table: "Partnerships",
                newName: "ModifedOn");

            migrationBuilder.RenameColumn(
                name: "IsDelete",
                table: "Orders",
                newName: "isDelete");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "Orders",
                newName: "isActive");

            migrationBuilder.RenameColumn(
                name: "ModifiedOn",
                table: "Orders",
                newName: "ModifedOn");

            migrationBuilder.RenameColumn(
                name: "IsDelete",
                table: "Notifications",
                newName: "isDelete");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "Notifications",
                newName: "isActive");

            migrationBuilder.RenameColumn(
                name: "ModifiedOn",
                table: "Notifications",
                newName: "ModifedOn");

            migrationBuilder.RenameColumn(
                name: "IsDelete",
                table: "Manufacturers",
                newName: "isDelete");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "Manufacturers",
                newName: "isActive");

            migrationBuilder.RenameColumn(
                name: "ModifiedOn",
                table: "Manufacturers",
                newName: "ModifedOn");

            migrationBuilder.RenameColumn(
                name: "IsDelete",
                table: "CompareCars",
                newName: "isDelete");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "CompareCars",
                newName: "isActive");

            migrationBuilder.RenameColumn(
                name: "ModifiedOn",
                table: "CompareCars",
                newName: "ModifedOn");

            migrationBuilder.RenameColumn(
                name: "IsDelete",
                table: "Companies",
                newName: "isDelete");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "Companies",
                newName: "isActive");

            migrationBuilder.RenameColumn(
                name: "ModifiedOn",
                table: "Companies",
                newName: "ModifedOn");

            migrationBuilder.RenameColumn(
                name: "IsDelete",
                table: "Cars",
                newName: "isDelete");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "Cars",
                newName: "isActive");

            migrationBuilder.RenameColumn(
                name: "ModifiedOn",
                table: "Cars",
                newName: "ModifedOn");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "a47646c7-9b30-4da5-b2b5-69c1a5aab739");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "215A41BD-E6D9-4A2F-97CC-0D7DCFDEB508",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "80ba0b82-4681-46b8-a90f-93d52ff7976f", "AQAAAAEAACcQAAAAEAbvMPEzNE9APCSq7TRgb7PNRkTA6GDj9Rl1iVjbI8hFGZwLMGtoB6SDN5TrTILCsA==", "eeeb34a5-23d2-4f13-93e6-5dd084fc8307" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32986053-7EB3-4D44-9612-6AF63933353E",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "447bc5b6-7551-4d82-a528-9cd5ad0c1e66", "AQAAAAEAACcQAAAAEJA5UR6mEfTi9OdHyLgQFLKHjGWSJeOGR3G+JwXiFfcwe7sRKns/Xg6/bORk+u1jsg==", "ad75a4c3-f902-484d-b139-92a9dd4f4474" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6777CE32-FBAA-4084-9EFF-A0C9290F0AFA",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7884b9ba-5a62-44a4-803d-87718d07fee3", "AQAAAAEAACcQAAAAEAf5UdFTPSb7Xk4pHnnTR+Zd9mC33Dk+xIjt7GCbVM77Zx+9e2Zgr51MINY9wxkdFA==", "b046120e-1c55-4139-9f87-3b78b2179588" });
        }
    }
}
