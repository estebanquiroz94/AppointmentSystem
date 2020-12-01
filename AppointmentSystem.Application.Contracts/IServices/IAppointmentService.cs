using AppointmentSystem.Application.Contracts.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppointmentSystem.Application.Contracts.IServices
{
    public interface IAppointmentService
    {
        Task<List<AppointmentDto>> GetAppointmentsByPatientDocument(string document);
    }
}
