using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace HastaneTMA.Model
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<AppointmentHour> AppointmentHours { get; set; }
        public virtual DbSet<Appointment> Appointments { get; set; }
        public virtual DbSet<Clinic> Clinics { get; set; }
        public virtual DbSet<Diagnostic> Diagnostics { get; set; }
        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Expens> Expenses { get; set; }
        public virtual DbSet<Income> Incomes { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppointmentHour>()
                .Property(e => e.HastaTC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Appointment>()
                .Property(e => e.TCNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Clinic>()
                .Property(e => e.KlinikAdi)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Clinic>()
                .HasMany(e => e.Doctors)
                .WithRequired(e => e.Clinic)
                .HasForeignKey(e => e.KlinikID);

            modelBuilder.Entity<Diagnostic>()
                .Property(e => e.HastaTC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Diagnostic>()
                .Property(e => e.Tani)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Ad)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Soyad)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Diagnostics)
                .WithRequired(e => e.Employee)
                .HasForeignKey(e => e.DoktorID);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Doctors)
                .WithRequired(e => e.Employee)
                .HasForeignKey(e => e.DoktorID);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.Employee)
                .HasForeignKey(e => e.CalisanNo);

            modelBuilder.Entity<Expens>()
                .Property(e => e.GiderAdi)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Income>()
                .Property(e => e.GelirAdi)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Patient>()
                .Property(e => e.Ad)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Patient>()
                .Property(e => e.Soyad)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Patient>()
                .Property(e => e.Ilce)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Patient>()
                .Property(e => e.Adres)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Patient>()
                .Property(e => e.PostaKodu)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Patient>()
                .Property(e => e.TCNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.KullaniciAdi)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Sifre)
                .IsUnicode(false);
        }
    }
}
