using AppointmentSystem.DataAccess.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AppointmentSystem.DataAccess.EntityConfig
{
    public class DoctorEntityConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<Doctor> entityBuilder)
        {
            entityBuilder.ToTable("Doctor");
            entityBuilder.HasKey(x => x.DoctorId);
            entityBuilder.Property(x => x.Name).IsRequired().HasMaxLength(100);
        }
    }
}
