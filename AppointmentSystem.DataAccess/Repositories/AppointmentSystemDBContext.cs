using AppointmentSystem.DataAccess.Contracts.Entities;
using AppointmentSystem.DataAccess.Contracts.IRepositories;
using AppointmentSystem.DataAccess.EntityConfig;
using Microsoft.EntityFrameworkCore;
namespace AppointmentSystem.DataAccess.Repositories
{
    public class AppointmentSystemDBContext : DbContext, IAppointmentSystemDBContext
    {
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<AppointmentDetail> AppointmentDetails { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public AppointmentSystemDBContext(DbContextOptions options) : base(options) { }
        public AppointmentSystemDBContext()
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            AppointmentDetailEntityConfig.SetEntityBuilder(modelBuilder.Entity<AppointmentDetail>());
            AppointmentEntityConfig.SetEntityBuilder(modelBuilder.Entity<Appointment>());
            DoctorEntityConfig.SetEntityBuilder(modelBuilder.Entity<Doctor>());
            PatientEntityConfig.SetEntityBuilder(modelBuilder.Entity<Patient>());
            base.OnModelCreating(modelBuilder);
        }
    }
}
