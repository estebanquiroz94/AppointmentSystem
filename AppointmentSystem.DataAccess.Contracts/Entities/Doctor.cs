using System;
using System.Collections.Generic;

namespace AppointmentSystem.DataAccess.Contracts.Entities
{
    public class Doctor
    {
        public Doctor()
        {
            this.AppointmentDetails = new HashSet<AppointmentDetail>();
        }
        public Guid DoctorId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<AppointmentDetail> AppointmentDetails { get; set; }
    }
}
