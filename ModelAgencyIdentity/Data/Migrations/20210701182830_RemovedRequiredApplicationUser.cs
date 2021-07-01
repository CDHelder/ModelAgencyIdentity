using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ModelAgencyIdentity.Migrations
{
    public partial class RemovedRequiredApplicationUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "187a9a15-f95a-460e-bc55-a6cc541fa948");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "86c364a5-2698-42a3-b157-0a0af5bb7c0d");

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: "0ec89ff6-7fed-42d4-af8c-995ef84f5231");

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: "5e6b7359-ab6c-49da-8d11-7302520c073a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "187a9a15-f95a-460e-bc55-a6cc541fa948");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "86c364a5-2698-42a3-b157-0a0af5bb7c0d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0ec89ff6-7fed-42d4-af8c-995ef84f5231");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5e6b7359-ab6c-49da-8d11-7302520c073a");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Models",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "Models",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AccountState", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "76cb4dce-91ca-45c1-b7d3-3963d5a7a49c", 0, 2, "ad33b842-d89e-413c-9de6-22b325c25cc2", "GekkeHenk@gmail.com", false, false, null, null, null, null, "06123456789", false, "caccdb6f-a822-4c2c-8618-2a6bd9f28ff1", false, "Henk" },
                    { "cb58b0bf-0a85-4c5c-b4ba-c7e2de220d70", 0, 2, "ed5ba415-7b13-4f89-a0ed-9c43a25518ce", "Jaapie@gmail.com", false, false, null, null, null, null, "06987654312", false, "df74b662-af25-403b-9905-75ab9fa02ad1", false, "Jaap" },
                    { "f5ef3d2d-9bed-4bed-ba3e-b7522fe75432", 0, 0, "87c10795-813d-4422-9c05-be5e27caf341", "Therese@gmail.com", false, false, null, null, null, null, "0645671234", false, "e1bafc4d-12bc-4e97-86ed-15f588ea2d78", false, "Therese" },
                    { "62963f36-b803-41e5-8349-d97529e899bd", 0, 0, "c38f8c59-1078-43a3-a7bc-51fa803db16e", "Peter@gmail.com", false, false, null, null, null, null, "0678901234", false, "84eeb76a-203f-4446-a718-67b2142fa953", false, "Peter" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "BTW", "Country", "KvK", "Name", "PostalCode", "StreetAddress" },
                values: new object[,]
                {
                    { "76cb4dce-91ca-45c1-b7d3-3963d5a7a49c", "123456789JWZ", "Nederland", "987654321JWZ", "Henk", "4201 GG", "Sesamstraat 12" },
                    { "cb58b0bf-0a85-4c5c-b4ba-c7e2de220d70", "67891234JWZ", "Nederland", "12341234JWZ", "Jaap", "6969 TR", "Zwaluwstraat 12" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "Country", "DOB", "EventId", "Name", "PostalCode", "StreetAddress" },
                values: new object[,]
                {
                    { "f5ef3d2d-9bed-4bed-ba3e-b7522fe75432", "Nederland", new DateTime(2021, 7, 1, 0, 0, 0, 0, DateTimeKind.Local), null, "Therese", "8844 JG", "Ruwinastraat 69" },
                    { "62963f36-b803-41e5-8349-d97529e899bd", "Nederland", new DateTime(2021, 7, 1, 0, 0, 0, 0, DateTimeKind.Local), null, "Peter", "3456 JG", "Gekkestraat 420" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "76cb4dce-91ca-45c1-b7d3-3963d5a7a49c");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "cb58b0bf-0a85-4c5c-b4ba-c7e2de220d70");

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: "62963f36-b803-41e5-8349-d97529e899bd");

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: "f5ef3d2d-9bed-4bed-ba3e-b7522fe75432");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "76cb4dce-91ca-45c1-b7d3-3963d5a7a49c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cb58b0bf-0a85-4c5c-b4ba-c7e2de220d70");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62963f36-b803-41e5-8349-d97529e899bd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f5ef3d2d-9bed-4bed-ba3e-b7522fe75432");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Models",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "Models",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AccountState", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "86c364a5-2698-42a3-b157-0a0af5bb7c0d", 0, 2, "6f33147d-7594-4cfc-938d-3867c90a5f97", "GekkeHenk@gmail.com", false, false, null, null, null, null, "06123456789", false, "192a7b27-7d16-4be3-aaa9-febf07ac472c", false, "Henk" },
                    { "187a9a15-f95a-460e-bc55-a6cc541fa948", 0, 2, "f208e4ed-d1de-47ca-a3c3-bab0e20412bb", "Jaapie@gmail.com", false, false, null, null, null, null, "06987654312", false, "51922178-f2b0-451b-b54e-7d910d24c0ca", false, "Jaap" },
                    { "0ec89ff6-7fed-42d4-af8c-995ef84f5231", 0, 0, "41f7c373-5ee6-41fa-b94f-fb7239e40b3b", "Therese@gmail.com", false, false, null, null, null, null, "0645671234", false, "b33c042d-b2b4-4856-8264-122fa1f9885a", false, "Therese" },
                    { "5e6b7359-ab6c-49da-8d11-7302520c073a", 0, 0, "2d465e2f-1d15-42c0-bef1-b83315a4c55d", "Peter@gmail.com", false, false, null, null, null, null, "0678901234", false, "6e0c5bad-2ffa-490f-a763-48e1eb9c780d", false, "Peter" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "BTW", "Country", "KvK", "Name", "PostalCode", "StreetAddress" },
                values: new object[,]
                {
                    { "86c364a5-2698-42a3-b157-0a0af5bb7c0d", "123456789JWZ", "Nederland", "987654321JWZ", "Henk", "4201 GG", "Sesamstraat 12" },
                    { "187a9a15-f95a-460e-bc55-a6cc541fa948", "67891234JWZ", "Nederland", "12341234JWZ", "Jaap", "6969 TR", "Zwaluwstraat 12" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "Country", "DOB", "EventId", "Name", "PostalCode", "StreetAddress" },
                values: new object[,]
                {
                    { "0ec89ff6-7fed-42d4-af8c-995ef84f5231", "Nederland", new DateTime(2021, 7, 1, 0, 0, 0, 0, DateTimeKind.Local), null, "Therese", "8844 JG", "Ruwinastraat 69" },
                    { "5e6b7359-ab6c-49da-8d11-7302520c073a", "Nederland", new DateTime(2021, 7, 1, 0, 0, 0, 0, DateTimeKind.Local), null, "Peter", "3456 JG", "Gekkestraat 420" }
                });
        }
    }
}
