using Microsoft.EntityFrameworkCore.Migrations;

namespace SofTechCore21MVC.Migrations
{
    public partial class addPhoneNo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TelephoneNo",
                table: "Customer",
                maxLength: 16,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TelephoneNo",
                table: "Customer");
        }
    }
}
