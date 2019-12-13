using Microsoft.EntityFrameworkCore.Migrations;

namespace SofTechCore21MVC.Migrations
{
    public partial class MakeCustomerFKsNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Address_AddressID",
                table: "Customer");

            migrationBuilder.DropForeignKey(
                name: "FK_Customer_PaymentCard_PaymentCardID",
                table: "Customer");

            migrationBuilder.AlterColumn<int>(
                name: "PaymentCardID",
                table: "Customer",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "AddressID",
                table: "Customer",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_Address_AddressID",
                table: "Customer",
                column: "AddressID",
                principalTable: "Address",
                principalColumn: "AddressID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_PaymentCard_PaymentCardID",
                table: "Customer",
                column: "PaymentCardID",
                principalTable: "PaymentCard",
                principalColumn: "PaymentCardID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Address_AddressID",
                table: "Customer");

            migrationBuilder.DropForeignKey(
                name: "FK_Customer_PaymentCard_PaymentCardID",
                table: "Customer");

            migrationBuilder.AlterColumn<int>(
                name: "PaymentCardID",
                table: "Customer",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AddressID",
                table: "Customer",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_Address_AddressID",
                table: "Customer",
                column: "AddressID",
                principalTable: "Address",
                principalColumn: "AddressID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_PaymentCard_PaymentCardID",
                table: "Customer",
                column: "PaymentCardID",
                principalTable: "PaymentCard",
                principalColumn: "PaymentCardID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
