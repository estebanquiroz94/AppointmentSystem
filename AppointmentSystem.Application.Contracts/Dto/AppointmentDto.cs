using System;

namespace AppointmentSystem.Application.Contracts.Dto
{
    public class AppointmentDto
    {
        public string Document { get; set; }
        public string DoctorName { get; set; }
        public string PatientName { get; set; }
        public DateTime Date { get; set; }
        public string Diagnostic { get; set; }
    }
}
