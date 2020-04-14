using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DoctorOffice.DataLayer.Migrations
{
    public partial class addConstantsConceptTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "constantConcepts",
                columns: table => new
                {
                    constantConceptsID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(maxLength: 200, nullable: false),
                    isActive = table.Column<int>(nullable: true),
                    createDateTime = table.Column<string>(maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_constantConcepts", x => x.constantConceptsID);
                    table.ForeignKey(
                        name: "FK_constantConcepts_constantConceptsID_isActive",
                        column: x => x.isActive,
                        principalTable: "constantConcepts",
                        principalColumn: "constantConceptsID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_constantConcepts_isActive",
                table: "constantConcepts",
                column: "isActive");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "constantConcepts");
        }
    }
}
