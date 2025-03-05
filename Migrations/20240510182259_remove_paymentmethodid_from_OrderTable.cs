using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarDoze.Migrations
{
    public partial class remove_paymentmethodid_from_OrderTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PaymentMethodID",
                table: "Orders");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PaymentMethodID",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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
    }
}
