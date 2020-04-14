﻿// <auto-generated />
using DoctorOffice.DataLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DoctorOffice.DataLayer.Migrations
{
    [DbContext(typeof(ProjectContext))]
    [Migration("20200207111259_AddSpecificationTable")]
    partial class AddSpecificationTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("DoctorOffice.Domains.Email", b =>
                {
                    b.Property<int>("emailID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("TitleEmail")
                        .IsRequired()
                        .HasColumnType("varchar(200) CHARACTER SET utf8mb4")
                        .HasMaxLength(200);

                    b.Property<string>("createDate")
                        .IsRequired()
                        .HasColumnType("varchar(10) CHARACTER SET utf8mb4")
                        .HasMaxLength(10);

                    b.Property<string>("formatEmail")
                        .IsRequired()
                        .HasColumnType("varchar(400) CHARACTER SET utf8mb4")
                        .HasMaxLength(400);

                    b.Property<string>("fullTextEmail")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4")
                        .HasMaxLength(5000);

                    b.Property<int>("turnsID")
                        .HasColumnType("int");

                    b.HasKey("emailID");

                    b.HasIndex("turnsID");

                    b.ToTable("Emails");
                });

            modelBuilder.Entity("DoctorOffice.Domains.Employees", b =>
                {
                    b.Property<int>("employeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<string>("birthDate")
                        .HasColumnType("varchar(10) CHARACTER SET utf8mb4")
                        .HasMaxLength(10);

                    b.Property<string>("createDate")
                        .IsRequired()
                        .HasColumnType("varchar(10) CHARACTER SET utf8mb4")
                        .HasMaxLength(10);

                    b.Property<string>("fatherName")
                        .HasColumnType("varchar(80) CHARACTER SET utf8mb4")
                        .HasMaxLength(80);

                    b.Property<string>("firstName")
                        .IsRequired()
                        .HasColumnType("varchar(80) CHARACTER SET utf8mb4")
                        .HasMaxLength(80);

                    b.Property<string>("imageName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("lastName")
                        .IsRequired()
                        .HasColumnType("varchar(180) CHARACTER SET utf8mb4")
                        .HasMaxLength(180);

                    b.Property<int>("nationalNumber")
                        .HasColumnType("int");

                    b.Property<int>("phoneNumber")
                        .HasColumnType("int");

                    b.HasKey("employeeID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("DoctorOffice.Domains.Medicine", b =>
                {
                    b.Property<int>("medicineID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descriptions")
                        .IsRequired()
                        .HasColumnType("varchar(300) CHARACTER SET utf8mb4")
                        .HasMaxLength(300);

                    b.Property<string>("createDate")
                        .IsRequired()
                        .HasColumnType("varchar(10) CHARACTER SET utf8mb4")
                        .HasMaxLength(10);

                    b.Property<int>("doctorsPrescriptionID")
                        .HasColumnType("int");

                    b.Property<string>("medicineName")
                        .IsRequired()
                        .HasColumnType("varchar(200) CHARACTER SET utf8mb4")
                        .HasMaxLength(200);

                    b.HasKey("medicineID");

                    b.HasIndex("doctorsPrescriptionID");

                    b.ToTable("Medicines");
                });

            modelBuilder.Entity("DoctorOffice.Domains.Memories", b =>
                {
                    b.Property<int>("MemoriesID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("createDate")
                        .IsRequired()
                        .HasColumnType("varchar(10) CHARACTER SET utf8mb4")
                        .HasMaxLength(10);

                    b.Property<string>("fullTextMemories")
                        .IsRequired()
                        .HasColumnType("varchar(600) CHARACTER SET utf8mb4")
                        .HasMaxLength(600);

                    b.Property<int>("likeCount")
                        .HasColumnType("int");

                    b.Property<string>("memoriesTitle")
                        .IsRequired()
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasMaxLength(100);

                    b.Property<int>("patientsID")
                        .HasColumnType("int");

                    b.HasKey("MemoriesID");

                    b.HasIndex("patientsID");

                    b.ToTable("Memories");
                });

            modelBuilder.Entity("DoctorOffice.Domains.Notes", b =>
                {
                    b.Property<int>("noteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("createDate")
                        .IsRequired()
                        .HasColumnType("varchar(10) CHARACTER SET utf8mb4")
                        .HasMaxLength(10);

                    b.Property<string>("fullTextNote")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("titleNote")
                        .IsRequired()
                        .HasColumnType("varchar(150) CHARACTER SET utf8mb4")
                        .HasMaxLength(150);

                    b.Property<int>("turnsID")
                        .HasColumnType("int");

                    b.HasKey("noteID");

                    b.HasIndex("turnsID");

                    b.ToTable("Notes");
                });

            modelBuilder.Entity("DoctorOffice.Domains.Payment", b =>
                {
                    b.Property<int>("paymentsID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descriptions")
                        .HasColumnType("varchar(300) CHARACTER SET utf8mb4")
                        .HasMaxLength(300);

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("createDate")
                        .IsRequired()
                        .HasColumnType("varchar(10) CHARACTER SET utf8mb4")
                        .HasMaxLength(10);

                    b.Property<long>("trackingCode")
                        .HasColumnType("bigint");

                    b.Property<int>("turnsID")
                        .HasColumnType("int");

                    b.Property<int>("typePayment")
                        .HasColumnType("int");

                    b.HasKey("paymentsID");

                    b.HasIndex("turnsID");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("DoctorOffice.Domains.SMS", b =>
                {
                    b.Property<int>("smsID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("TitleSMS")
                        .IsRequired()
                        .HasColumnType("varchar(200) CHARACTER SET utf8mb4")
                        .HasMaxLength(200);

                    b.Property<string>("createDate")
                        .IsRequired()
                        .HasColumnType("varchar(10) CHARACTER SET utf8mb4")
                        .HasMaxLength(10);

                    b.Property<string>("formatSMS")
                        .IsRequired()
                        .HasColumnType("varchar(400) CHARACTER SET utf8mb4")
                        .HasMaxLength(400);

                    b.Property<string>("fullTextSMS")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4")
                        .HasMaxLength(5000);

                    b.Property<int>("turnsID")
                        .HasColumnType("int");

                    b.HasKey("smsID");

                    b.HasIndex("turnsID");

                    b.ToTable("SMS");
                });

            modelBuilder.Entity("DoctorOffice.Domains.Temporarypatients", b =>
                {
                    b.Property<int>("temporaryPatientsID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("birthDate")
                        .IsRequired()
                        .HasColumnType("varchar(10) CHARACTER SET utf8mb4")
                        .HasMaxLength(10);

                    b.Property<string>("createDate")
                        .IsRequired()
                        .HasColumnType("varchar(10) CHARACTER SET utf8mb4")
                        .HasMaxLength(10);

                    b.Property<string>("fatherName")
                        .IsRequired()
                        .HasColumnType("varchar(80) CHARACTER SET utf8mb4")
                        .HasMaxLength(80);

                    b.Property<string>("firstName")
                        .IsRequired()
                        .HasColumnType("varchar(80) CHARACTER SET utf8mb4")
                        .HasMaxLength(80);

                    b.Property<string>("lastName")
                        .IsRequired()
                        .HasColumnType("varchar(180) CHARACTER SET utf8mb4")
                        .HasMaxLength(180);

                    b.Property<int>("nationalNumber")
                        .HasColumnType("int");

                    b.Property<int>("phoneNumber")
                        .HasColumnType("int");

                    b.HasKey("temporaryPatientsID");

                    b.ToTable("temporaryPatients");
                });

            modelBuilder.Entity("DoctorOffice.Domains.Turns", b =>
                {
                    b.Property<int>("turnsID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descriptions")
                        .HasColumnType("varchar(300) CHARACTER SET utf8mb4")
                        .HasMaxLength(300);

                    b.Property<string>("createDate")
                        .IsRequired()
                        .HasColumnType("varchar(10) CHARACTER SET utf8mb4")
                        .HasMaxLength(10);

                    b.Property<int>("employeeID")
                        .HasColumnType("int");

                    b.Property<int>("patientsID")
                        .HasColumnType("int");

                    b.Property<string>("reserveDate")
                        .IsRequired()
                        .HasColumnType("varchar(10) CHARACTER SET utf8mb4")
                        .HasMaxLength(10);

                    b.Property<int>("statusTurn")
                        .HasColumnType("int");

                    b.Property<int>("temporaryPatientsID")
                        .HasColumnType("int");

                    b.HasKey("turnsID");

                    b.HasIndex("employeeID");

                    b.HasIndex("patientsID");

                    b.HasIndex("temporaryPatientsID");

                    b.ToTable("Turns");
                });

            modelBuilder.Entity("DoctorOffice.Domains.doctorsPrescription", b =>
                {
                    b.Property<int>("doctorsPrescriptionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("PrescriptionDescriptions")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("createDate")
                        .IsRequired()
                        .HasColumnType("varchar(10) CHARACTER SET utf8mb4")
                        .HasMaxLength(10);

                    b.Property<int>("prescriptionStatus")
                        .HasColumnType("int");

                    b.Property<int>("turnsID")
                        .HasColumnType("int");

                    b.HasKey("doctorsPrescriptionID");

                    b.HasIndex("turnsID");

                    b.ToTable("doctorsPrescriptions");
                });

            modelBuilder.Entity("DoctorOffice.Domains.howUse", b =>
                {
                    b.Property<int>("howUseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descriptions")
                        .IsRequired()
                        .HasColumnType("varchar(300) CHARACTER SET utf8mb4")
                        .HasMaxLength(300);

                    b.Property<string>("createDate")
                        .IsRequired()
                        .HasColumnType("varchar(10) CHARACTER SET utf8mb4")
                        .HasMaxLength(10);

                    b.Property<string>("howUseText")
                        .IsRequired()
                        .HasColumnType("varchar(1000) CHARACTER SET utf8mb4")
                        .HasMaxLength(1000);

                    b.Property<int>("medicineID")
                        .HasColumnType("int");

                    b.Property<string>("useFrom")
                        .IsRequired()
                        .HasColumnType("varchar(10) CHARACTER SET utf8mb4")
                        .HasMaxLength(10);

                    b.Property<string>("useTo")
                        .IsRequired()
                        .HasColumnType("varchar(10) CHARACTER SET utf8mb4")
                        .HasMaxLength(10);

                    b.HasKey("howUseID");

                    b.HasIndex("medicineID");

                    b.ToTable("howUses");
                });

            modelBuilder.Entity("DoctorOffice.Domains.patients", b =>
                {
                    b.Property<int>("patientsID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("birthDate")
                        .IsRequired()
                        .HasColumnType("varchar(10) CHARACTER SET utf8mb4")
                        .HasMaxLength(10);

                    b.Property<string>("createDate")
                        .IsRequired()
                        .HasColumnType("varchar(10) CHARACTER SET utf8mb4")
                        .HasMaxLength(10);

                    b.Property<string>("fatherName")
                        .IsRequired()
                        .HasColumnType("varchar(80) CHARACTER SET utf8mb4")
                        .HasMaxLength(80);

                    b.Property<string>("firstName")
                        .IsRequired()
                        .HasColumnType("varchar(80) CHARACTER SET utf8mb4")
                        .HasMaxLength(80);

                    b.Property<string>("imageName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("lastName")
                        .IsRequired()
                        .HasColumnType("varchar(180) CHARACTER SET utf8mb4")
                        .HasMaxLength(180);

                    b.Property<int>("nationalNumber")
                        .HasColumnType("int");

                    b.Property<int>("phoneNumber")
                        .HasColumnType("int");

                    b.HasKey("patientsID");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("DoctorOffice.Domains.Email", b =>
                {
                    b.HasOne("DoctorOffice.Domains.Turns", "Turns")
                        .WithMany("Emails")
                        .HasForeignKey("turnsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DoctorOffice.Domains.Medicine", b =>
                {
                    b.HasOne("DoctorOffice.Domains.doctorsPrescription", "DoctosPrescription")
                        .WithMany("Medicines")
                        .HasForeignKey("doctorsPrescriptionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DoctorOffice.Domains.Memories", b =>
                {
                    b.HasOne("DoctorOffice.Domains.patients", "Patients")
                        .WithMany("Memories")
                        .HasForeignKey("patientsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DoctorOffice.Domains.Notes", b =>
                {
                    b.HasOne("DoctorOffice.Domains.Turns", "Turns")
                        .WithMany("Notes")
                        .HasForeignKey("turnsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DoctorOffice.Domains.Payment", b =>
                {
                    b.HasOne("DoctorOffice.Domains.Turns", "Turns")
                        .WithMany("Payments")
                        .HasForeignKey("turnsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DoctorOffice.Domains.SMS", b =>
                {
                    b.HasOne("DoctorOffice.Domains.Turns", "Turns")
                        .WithMany("SMS")
                        .HasForeignKey("turnsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DoctorOffice.Domains.Turns", b =>
                {
                    b.HasOne("DoctorOffice.Domains.Employees", "Employees")
                        .WithMany("Turns")
                        .HasForeignKey("employeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoctorOffice.Domains.patients", "Patients")
                        .WithMany("Turns")
                        .HasForeignKey("patientsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoctorOffice.Domains.Temporarypatients", "temporaryPatients")
                        .WithMany("Turns")
                        .HasForeignKey("temporaryPatientsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DoctorOffice.Domains.doctorsPrescription", b =>
                {
                    b.HasOne("DoctorOffice.Domains.Turns", "Turns")
                        .WithMany("DoctosPrescriptions")
                        .HasForeignKey("turnsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DoctorOffice.Domains.howUse", b =>
                {
                    b.HasOne("DoctorOffice.Domains.Medicine", "Medicine")
                        .WithMany("howUses")
                        .HasForeignKey("medicineID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
