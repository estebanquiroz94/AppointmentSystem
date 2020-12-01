using AppointmentSystem.DataAccess.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AppointmentSystem.DataAccess.EntityConfig
{
    public class AppointmentDetailEntityConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<AppointmentDetail> entityBuilder)
        {
            entityBuilder.ToTable("AppointmentDetail");
            entityBuilder.HasKey(x => x.AppointmentDetailId);
            entityBuilder.Property(x => x.Diagnostic).IsRequired().HasMaxLength(500);
            entityBuilder.HasOne(x => x.Doctor).WithMany(x => x.AppointmentDetails).HasForeignKey(x => x.DoctorId);
            entityBuilder.HasOne(x => x.Patient).WithMany(x => x.AppointmentDetails).HasForeignKey(x => x.PatientId);
            entityBuilder.HasOne(x => x.Appointment).WithMany(x => x.AppointmentDetails).HasForeignKey(x => x.AppointmentId);
        }
    }
}
