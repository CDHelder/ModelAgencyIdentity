using Microsoft.EntityFrameworkCore.Migrations;

namespace ModelAgencyIdentity.Data.Migrations
{
    public partial class AddedAccountState : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AccountState",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccountState",
                table: "AspNetUsers");
        }
    }
}
