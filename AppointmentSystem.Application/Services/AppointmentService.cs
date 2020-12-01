using AppointmentSystem.Application.Contracts.Dto;
using AppointmentSystem.Application.Contracts.IServices;
using AppointmentSystem.DataAccess.Contracts.IRepositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppointmentSystem.Application.Services
{
    public class AppointmentService : IAppointmentService
    {
        private readonly IAppointmentSystemDBContext _appointmentSystemDBContext;
        public AppointmentService(IAppointmentSystemDBContext appointmentSystemDBContext)
        {
            _appointmentSystemDBContext = appointmentSystemDBContext;
        }
        public async Task<List<AppointmentDto>> GetAppointmentsByPatientDocument(string document)
        {
            List<AppointmentDto> appointmentDtos = await _appointmentSystemDBContext.AppointmentDetails.Where(w => w.Patient.Document == document)
                  .Select(s => new AppointmentDto()
                  {
                      Document = s.Patient.Document,
                      Date = s.Appointment.Date,
                      DoctorName = s.Doctor.Name,
                      PatientName = s.Patient.Name,
                      Diagnostic = s.Diagnostic
                  }).ToListAsync();
            return appointmentDtos;
        }
    }
}
