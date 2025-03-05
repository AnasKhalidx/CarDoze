using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarDoze.Migrations
{
    public partial class added_base_entityinto_shippingaddress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "ShippingAddresses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "ShippingAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "ShippingAddresses",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "ShippingAddresses",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "ShippingAddresses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedOn",
                table: "ShippingAddresses",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "5adb2a5b-9c18-4a42-a8f9-abc559c4f090");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "215A41BD-E6D9-4A2F-97CC-0D7DCFDEB508",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d0492e21-eef9-406d-bf06-08edac183932", "AQAAAAEAACcQAAAAEITsYz6TZG3REWox1lMYpoklefFBxflKQ3Ks/yxVtmX0zNbx/v633/f3NtB2w33T0Q==", "798ac41d-0d92-4178-9898-2ad2113de401" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32986053-7EB3-4D44-9612-6AF63933353E",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7b3dff5b-b80c-4122-906b-f360e1ab512e", "AQAAAAEAACcQAAAAEMFMeqRSNNcI8+fU7oDGxTGVE/Q87UXcEf1vXU71uJkaSsSIj5tiKjJj3F2QXNQHcw==", "37f8ba22-adc9-4f61-ba57-aee62b5dd76c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6777CE32-FBAA-4084-9EFF-A0C9290F0AFA",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8b5c0759-e515-4d0d-a9dd-f28361d807e4", "AQAAAAEAACcQAAAAELv8YJP9IQiKLa3/1/bB4shPWfLtmZNwcm9Zl+bSxXLLFrV4QCSsuOMi3zFIZlxW/A==", "234b5575-0ca9-4488-9fc9-ef25c6a5dfab" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "ShippingAddresses");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "ShippingAddresses");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "ShippingAddresses");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "ShippingAddresses");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "ShippingAddresses");

            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                table: "ShippingAddresses");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "2bb44221-7043-4a87-8e66-4d96c938d6a1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "215A41BD-E6D9-4A2F-97CC-0D7DCFDEB508",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "641bf8c0-57f8-4d80-a888-5618d44cf36f", "AQAAAAEAACcQAAAAEHxYcjsoFdwGy3q01WHI8Gw+N7snG2Gw2I28h8hwd9/kl+CRbIGj/K9ZHFpYsiNGNw==", "bd0509b9-8752-4b1c-b67e-52c61aaf3926" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32986053-7EB3-4D44-9612-6AF63933353E",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c464bb04-9046-45cb-b593-a7c22c78144b", "AQAAAAEAACcQAAAAEEG5OVrd5OhKmYHKVXqpibynm18u4KrDfRCPK1FRdQ8eJ4A4uyujZJXS9rfAYbN8wg==", "bdaae11a-9b34-4482-baba-6876ad389542" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6777CE32-FBAA-4084-9EFF-A0C9290F0AFA",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2315e181-e238-43a5-a92a-22180560cb5d", "AQAAAAEAACcQAAAAEBPeW57OLbH13J9g8a54oSrghv7MzgjMOI7+FasxTprlhxPgXsnkb7jEGS43hkJkMA==", "e9de4c87-e32e-4dc2-b51f-387d84ccb080" });
        }
    }
}
