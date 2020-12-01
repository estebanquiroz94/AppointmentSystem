using System;
using System.Collections.Generic;

namespace AppointmentSystem.DataAccess.Contracts.Entities
{
    public class Patient
    {
        public Guid PatientId { get; set; }
        public string Document { get; set; }
        public string Name { get; set; }
        public virtual ICollection<AppointmentDetail> AppointmentDetails { get; set; }
    }
}
