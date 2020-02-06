using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tutor_Appointments_Core_Web_App.BusinessLayer
{
    //Tutor information
    public class Tutor
    {
        //Tutor id
        public int Id { get; set; }

        //Tutor name
        public string Name { get; set; }

        //Tutor email
        public string TutorEmail { get; set; }

        //Tutor mobile
        public string Mobile { get; set; }

        //Tutor faculty information
        public int FacultyId { get; set; }

        public Faculty Faculty { get; set; }

    }
}
