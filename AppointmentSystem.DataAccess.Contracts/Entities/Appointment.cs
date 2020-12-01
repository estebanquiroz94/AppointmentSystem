using System;
using System.Collections.Generic;

namespace AppointmentSystem.DataAccess.Contracts.Entities
{
    public class Appointment
    {
        public Appointment()
        {
            this.AppointmentDetails = new HashSet<AppointmentDetail>();
        }
        public Guid AppointmentId { get; set; }
        public DateTime Date { get; set; }
        public virtual ICollection<AppointmentDetail> AppointmentDetails { get; set; }
    }
}
