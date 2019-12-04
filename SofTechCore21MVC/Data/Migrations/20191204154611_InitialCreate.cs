using Microsoft.EntityFrameworkCore.Migrations;

namespace SofTechCore21MVC.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PaymentCard",
                columns: table => new
                {
                    PaymentCardID = table.Column<string>(nullable: false),
                    CardType = table.Column<int>(nullable: false),
                    CardName = table.Column<string>(maxLength: 30, nullable: false),
                    CardNumber = table.Column<string>(maxLength: 20, nullable: false),
                    ExpiryMonth = table.Column<int>(nullable: false),
                    ExpiryYear = table.Column<int>(nullable: false),
                    SecurityNumber = table.Column<int>(maxLength: 3, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentCard", x => x.PaymentCardID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PaymentCard");
        }
    }
}
