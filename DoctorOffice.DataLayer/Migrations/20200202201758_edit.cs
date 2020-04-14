using Microsoft.EntityFrameworkCore.Migrations;

namespace DoctorOffice.DataLayer.Migrations
{
    public partial class edit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Turns_Employees_EmployeesemployeeID",
                table: "Turns");

            migrationBuilder.DropIndex(
                name: "IX_Turns_EmployeesemployeeID",
                table: "Turns");

            migrationBuilder.DropColumn(
                name: "EmployeesemployeeID",
                table: "Turns");

            migrationBuilder.CreateIndex(
                name: "IX_Turns_employeeID",
                table: "Turns",
                column: "employeeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Turns_Employees_employeeID",
                table: "Turns",
                column: "employeeID",
                principalTable: "Employees",
                principalColumn: "employeeID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Turns_Employees_employeeID",
                table: "Turns");

            migrationBuilder.DropIndex(
                name: "IX_Turns_employeeID",
                table: "Turns");

            migrationBuilder.AddColumn<int>(
                name: "EmployeesemployeeID",
                table: "Turns",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Turns_EmployeesemployeeID",
                table: "Turns",
                column: "EmployeesemployeeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Turns_Employees_EmployeesemployeeID",
                table: "Turns",
                column: "EmployeesemployeeID",
                principalTable: "Employees",
                principalColumn: "employeeID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
