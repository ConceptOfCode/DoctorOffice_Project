using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DoctorOffice.DataLayer.Migrations
{
    public partial class addPaymentTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    paymentsID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    turnsID = table.Column<int>(nullable: false),
                    typePayment = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    trackingCode = table.Column<long>(nullable: false),
                    createDate = table.Column<string>(maxLength: 10, nullable: false),
                    Descriptions = table.Column<string>(maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.paymentsID);
                    table.ForeignKey(
                        name: "FK_Payments_Turns_turnsID",
                        column: x => x.turnsID,
                        principalTable: "Turns",
                        principalColumn: "turnsID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Payments_turnsID",
                table: "Payments",
                column: "turnsID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Payments");
        }
    }
}
