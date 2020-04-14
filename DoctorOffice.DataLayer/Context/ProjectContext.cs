using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using DoctorOffice.Domains;

namespace DoctorOffice.DataLayer
{
    public class ProjectContext : DbContext
    {
        public ProjectContext(DbContextOptions<ProjectContext> options) : base(options)
        {

        }

        public DbSet<patients> Patients { get; set; }
        public DbSet<Temporarypatients> temporaryPatients { get; set; }
        public DbSet<Employees> Employees { get; set; }
        public DbSet<Turns> Turns { get; set; }
        public DbSet<SMS> SMS { get; set; }
        public DbSet<Email> Emails { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Notes> Notes { get; set; }
        public DbSet<doctorsPrescription> doctorsPrescriptions { get; set; }
        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<howUse> howUses { get; set; }
        public DbSet<constantConcepts> constantConcepts { get; set; }
        public DbSet<Services> Services { get; set; }
        public DbSet<Memories> Memories { get; set; }
        public DbSet<clinicSpecifications> clinicSpecifications { get; set; }
        public DbSet<clinicOpeningHours> clinicOpeningHours { get; set; }
    }
}
