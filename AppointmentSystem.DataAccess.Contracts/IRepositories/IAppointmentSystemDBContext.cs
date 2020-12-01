using AppointmentSystem.DataAccess.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;
namespace AppointmentSystem.DataAccess.Contracts.IRepositories
{
    public interface IAppointmentSystemDBContext
    {
         DbSet<Appointment> Appointments { get; set; }
         DbSet<Doctor> Doctors { get; set; }
         DbSet<AppointmentDetail> AppointmentDetails { get; set; }
         DbSet<Patient> Patients { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
    }
}
