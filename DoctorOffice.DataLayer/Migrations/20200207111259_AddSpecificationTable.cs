using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DoctorOffice.DataLayer.Migrations
{
    public partial class AddSpecificationTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
               name: "clinicSpecifications",
               columns: table => new
               {
                   clinicSpecificationsID = table.Column<int>(nullable: false)
                       .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                   streetName = table.Column<string>(maxLength:100,nullable: false),
                   countryName = table.Column<string>(maxLength: 100, nullable: false),
                   cityName = table.Column<string>(maxLength: 100, nullable: false),
                   clinicPhone = table.Column<string>(maxLength: 12, nullable: false),
                   clinicPlack = table.Column<string>(maxLength:3, nullable: false),
                   fullAddress = table.Column<string>(maxLength: 500, nullable: false),
                   isActive = table.Column<bool>(nullable: false),
                   createDate = table.Column<string>(maxLength: 10, nullable: false)
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_clinicSpecifications", x => x.clinicSpecificationsID);
               });

            migrationBuilder.CreateTable(
              name: "clinicOpeningHours",
              columns: table => new
              {
                  clinicOpeningHoursID = table.Column<int>(nullable: false)
                      .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                  clinicSpecificationsID = table.Column<int>(nullable: false),
                  weekDay = table.Column<string>(maxLength: 10, nullable: false),
                  startTime = table.Column<string>(maxLength: 50, nullable: false),
                  endTime = table.Column<string>(maxLength: 50,nullable: false),
                  isActive = table.Column<bool>(nullable: false),
                  createDate = table.Column<string>(maxLength: 10, nullable: false),
              },
              constraints: table =>
              {
                  table.PrimaryKey("PK_clinicOpeningHours", x => x.clinicOpeningHoursID);
                  table.ForeignKey(
                      name: "FK_clinicOpeningHours_clinicSpecifications_clinicSpecificationsID",
                      column: x => x.clinicSpecificationsID,
                      principalTable: "clinicSpecifications",
                      principalColumn: "clinicSpecificationsID",
                      onDelete: ReferentialAction.Cascade);
              });

            migrationBuilder.CreateIndex(
                name: "IX_clinicOpeningHours_clinicSpecificationsID",
                table: "clinicOpeningHours",
                column: "clinicSpecificationsID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
               name: "clinicSpecifications");

            migrationBuilder.DropTable(
             name: "clinicOpeningHours");
        }
    }
}
