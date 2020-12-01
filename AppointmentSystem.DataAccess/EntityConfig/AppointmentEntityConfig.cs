using AppointmentSystem.DataAccess.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AppointmentSystem.DataAccess.EntityConfig
{
    public class AppointmentEntityConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<Appointment> entityBuilder)
        {
            entityBuilder.ToTable("Appointment");
            entityBuilder.HasKey(x => x.AppointmentId);
            entityBuilder.Property(x => x.Date).IsRequired();
        }
    }
}
