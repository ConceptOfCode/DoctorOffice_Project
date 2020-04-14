using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DoctorOffice.DataLayer.Migrations
{
    public partial class addConstantTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "costantConcepts",
                columns: table => new
                {
                    costantConceptsID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(maxLength: 200, nullable: false),
                    isActive = table.Column<int>(nullable: true),
                    createDateTime = table.Column<string>(maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_costantConcepts", x => x.costantConceptsID);
                    table.ForeignKey(
                        name: "FK_costantConcepts_costantConcepts_isActive",
                        column: x => x.isActive,
                        principalTable: "costantConcepts",
                        principalColumn: "costantConceptsID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_costantConcepts_isActive",
                table: "costantConcepts",
                column: "isActive");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "costantConcepts");
        }
    }
}
