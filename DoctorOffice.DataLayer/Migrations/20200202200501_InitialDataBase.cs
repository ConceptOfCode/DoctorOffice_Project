using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DoctorOffice.DataLayer.Migrations
{
    public partial class InitialDataBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    employeeID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    firstName = table.Column<string>(maxLength: 80, nullable: false),
                    lastName = table.Column<string>(maxLength: 180, nullable: false),
                    fatherName = table.Column<string>(maxLength: 80, nullable: true),
                    nationalNumber = table.Column<int>(nullable: false),
                    birthDate = table.Column<string>(maxLength: 10, nullable: true),
                    createDate = table.Column<string>(maxLength: 10, nullable: false),
                    imageName = table.Column<string>(nullable: true),
                    phoneNumber = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.employeeID);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    patientsID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    firstName = table.Column<string>(maxLength: 80, nullable: false),
                    lastName = table.Column<string>(maxLength: 180, nullable: false),
                    fatherName = table.Column<string>(maxLength: 80, nullable: false),
                    nationalNumber = table.Column<int>(nullable: false),
                    birthDate = table.Column<string>(maxLength: 10, nullable: false),
                    createDate = table.Column<string>(maxLength: 10, nullable: false),
                    imageName = table.Column<string>(nullable: true),
                    phoneNumber = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.patientsID);
                });

            migrationBuilder.CreateTable(
                name: "temporaryPatients",
                columns: table => new
                {
                    temporaryPatientsID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    firstName = table.Column<string>(maxLength: 80, nullable: false),
                    lastName = table.Column<string>(maxLength: 180, nullable: false),
                    fatherName = table.Column<string>(maxLength: 80, nullable: false),
                    nationalNumber = table.Column<int>(nullable: false),
                    birthDate = table.Column<string>(maxLength: 10, nullable: false),
                    createDate = table.Column<string>(maxLength: 10, nullable: false),
                    phoneNumber = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_temporaryPatients", x => x.temporaryPatientsID);
                });

            migrationBuilder.CreateTable(
                name: "Turns",
                columns: table => new
                {
                    turnsID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    patientsID = table.Column<int>(nullable: false),
                    temporaryPatientsID = table.Column<int>(nullable: false),
                    employeeID = table.Column<int>(nullable: false),
                    reserveDate = table.Column<string>(maxLength: 10, nullable: false),
                    createDate = table.Column<string>(maxLength: 10, nullable: false),
                    statusTurn = table.Column<int>(nullable: false),
                    Descriptions = table.Column<string>(maxLength: 300, nullable: true),
                    EmployeesemployeeID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Turns", x => x.turnsID);
                    table.ForeignKey(
                        name: "FK_Turns_Employees_EmployeesemployeeID",
                        column: x => x.EmployeesemployeeID,
                        principalTable: "Employees",
                        principalColumn: "employeeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Turns_Patients_patientsID",
                        column: x => x.patientsID,
                        principalTable: "Patients",
                        principalColumn: "patientsID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Turns_temporaryPatients_temporaryPatientsID",
                        column: x => x.temporaryPatientsID,
                        principalTable: "temporaryPatients",
                        principalColumn: "temporaryPatientsID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "doctorsPrescriptions",
                columns: table => new
                {
                    doctorsPrescriptionID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    turnsID = table.Column<int>(nullable: false),
                    createDate = table.Column<string>(maxLength: 10, nullable: false),
                    prescriptionStatus = table.Column<int>(nullable: false),
                    PrescriptionDescriptions = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_doctorsPrescriptions", x => x.doctorsPrescriptionID);
                    table.ForeignKey(
                        name: "FK_doctorsPrescriptions_Turns_turnsID",
                        column: x => x.turnsID,
                        principalTable: "Turns",
                        principalColumn: "turnsID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Emails",
                columns: table => new
                {
                    emailID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    turnsID = table.Column<int>(nullable: false),
                    TitleEmail = table.Column<string>(maxLength: 200, nullable: false),
                    formatEmail = table.Column<string>(maxLength: 400, nullable: false),
                    fullTextEmail = table.Column<string>(maxLength: 5000, nullable: false),
                    createDate = table.Column<string>(maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emails", x => x.emailID);
                    table.ForeignKey(
                        name: "FK_Emails_Turns_turnsID",
                        column: x => x.turnsID,
                        principalTable: "Turns",
                        principalColumn: "turnsID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Notes",
                columns: table => new
                {
                    noteID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    turnsID = table.Column<int>(nullable: false),
                    titleNote = table.Column<string>(maxLength: 150, nullable: false),
                    fullTextNote = table.Column<string>(nullable: false),
                    createDate = table.Column<string>(maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notes", x => x.noteID);
                    table.ForeignKey(
                        name: "FK_Notes_Turns_turnsID",
                        column: x => x.turnsID,
                        principalTable: "Turns",
                        principalColumn: "turnsID",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateTable(
                name: "SMS",
                columns: table => new
                {
                    smsID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    turnsID = table.Column<int>(nullable: false),
                    TitleSMS = table.Column<string>(maxLength: 200, nullable: false),
                    formatSMS = table.Column<string>(maxLength: 400, nullable: false),
                    fullTextSMS = table.Column<string>(maxLength: 5000, nullable: false),
                    createDate = table.Column<string>(maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SMS", x => x.smsID);
                    table.ForeignKey(
                        name: "FK_SMS_Turns_turnsID",
                        column: x => x.turnsID,
                        principalTable: "Turns",
                        principalColumn: "turnsID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Medicines",
                columns: table => new
                {
                    medicineID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    doctorsPrescriptionID = table.Column<int>(nullable: false),
                    medicineName = table.Column<string>(maxLength: 200, nullable: false),
                    createDate = table.Column<string>(maxLength: 10, nullable: false),
                    Descriptions = table.Column<string>(maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicines", x => x.medicineID);
                    table.ForeignKey(
                        name: "FK_Medicines_doctorsPrescriptions_doctorsPrescriptionID",
                        column: x => x.doctorsPrescriptionID,
                        principalTable: "doctorsPrescriptions",
                        principalColumn: "doctorsPrescriptionID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "howUses",
                columns: table => new
                {
                    howUseID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    medicineID = table.Column<int>(nullable: false),
                    howUseText = table.Column<string>(maxLength: 1000, nullable: false),
                    useFrom = table.Column<string>(maxLength: 10, nullable: false),
                    useTo = table.Column<string>(maxLength: 10, nullable: false),
                    createDate = table.Column<string>(maxLength: 10, nullable: false),
                    Descriptions = table.Column<string>(maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_howUses", x => x.howUseID);
                    table.ForeignKey(
                        name: "FK_howUses_Medicines_medicineID",
                        column: x => x.medicineID,
                        principalTable: "Medicines",
                        principalColumn: "medicineID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_doctorsPrescriptions_turnsID",
                table: "doctorsPrescriptions",
                column: "turnsID");

            migrationBuilder.CreateIndex(
                name: "IX_Emails_turnsID",
                table: "Emails",
                column: "turnsID");

            migrationBuilder.CreateIndex(
                name: "IX_howUses_medicineID",
                table: "howUses",
                column: "medicineID");

            migrationBuilder.CreateIndex(
                name: "IX_Medicines_doctorsPrescriptionID",
                table: "Medicines",
                column: "doctorsPrescriptionID");

            migrationBuilder.CreateIndex(
                name: "IX_Notes_turnsID",
                table: "Notes",
                column: "turnsID");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_turnsID",
                table: "Payments",
                column: "turnsID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SMS_turnsID",
                table: "SMS",
                column: "turnsID");

            migrationBuilder.CreateIndex(
                name: "IX_Turns_EmployeesemployeeID",
                table: "Turns",
                column: "EmployeesemployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Turns_patientsID",
                table: "Turns",
                column: "patientsID");

            migrationBuilder.CreateIndex(
                name: "IX_Turns_temporaryPatientsID",
                table: "Turns",
                column: "temporaryPatientsID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Emails");

            migrationBuilder.DropTable(
                name: "howUses");

            migrationBuilder.DropTable(
                name: "Notes");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "SMS");

            migrationBuilder.DropTable(
                name: "Medicines");

            migrationBuilder.DropTable(
                name: "doctorsPrescriptions");

            migrationBuilder.DropTable(
                name: "Turns");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "temporaryPatients");
        }
    }
}
