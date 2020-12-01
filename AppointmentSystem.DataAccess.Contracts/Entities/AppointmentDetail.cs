using System;

namespace AppointmentSystem.DataAccess.Contracts.Entities
{
    public class AppointmentDetail
    {
        public Guid AppointmentDetailId { get; set; }
        public Guid AppointmentId { get; set; }
        public Guid PatientId { get; set; }
        public Guid DoctorId { get; set; }
        public int ConsultingRoom { get; set; }
        public string Diagnostic { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual Appointment Appointment { get; set; }
        public virtual Doctor Doctor { get; set; }
    }
}
