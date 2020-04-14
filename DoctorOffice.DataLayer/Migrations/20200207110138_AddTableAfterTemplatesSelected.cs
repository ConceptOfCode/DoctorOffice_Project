using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DoctorOffice.DataLayer.Migrations
{
    public partial class AddTableAfterTemplatesSelected : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.CreateTable(
                name: "Memories",
                columns: table => new
                {
                    MemoriesID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    patientsID = table.Column<int>(nullable: false),
                    memoriesTitle = table.Column<string>(maxLength: 100, nullable: false),
                    fullTextMemories = table.Column<string>(maxLength: 600, nullable: false),
                    createDate = table.Column<string>(maxLength: 10, nullable: false),
                    likeCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Memories", x => x.MemoriesID);
                    table.ForeignKey(
                        name: "FK_Memories_Patients_patientsID",
                        column: x => x.patientsID,
                        principalTable: "Patients",
                        principalColumn: "patientsID",
                        onDelete: ReferentialAction.Cascade);
                });


            migrationBuilder.CreateIndex(
                name: "IX_Memories_patientsID",
                table: "Memories",
                column: "patientsID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
          

            migrationBuilder.DropTable(
                name: "Memories");

        }
    }
}
