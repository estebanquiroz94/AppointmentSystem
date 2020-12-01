using AppointmentSystem.DataAccess.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AppointmentSystem.DataAccess.EntityConfig
{
    public class PatientEntityConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<Patient> entityBuilder)
        {
            entityBuilder.ToTable("Patient");
            entityBuilder.HasKey(x => x.PatientId);
            entityBuilder.Property(x => x.Document).IsRequired().HasMaxLength(20);
            entityBuilder.Property(x => x.Name).IsRequired();
        }
    }
}
