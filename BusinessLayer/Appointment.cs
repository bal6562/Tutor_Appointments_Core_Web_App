using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tutor_Appointments_Core_Web_App.BusinessLayer
{
    //Appointmnt details
    public class Appointment
    {
        //Appointment id
        public int Id { get; set; }

        //Student Id foriegn key
        public int StudentId { get; set; }

        //Tutor id foriegn key
        public int TutorId { get; set; }

        //Tutor reference
        public Tutor Tutor { get; set; }

        //Student reference
        public Student Student { get; set; }

        //Appointment date
        public DateTime AppointmentDate  { get; set; }

    }
}
