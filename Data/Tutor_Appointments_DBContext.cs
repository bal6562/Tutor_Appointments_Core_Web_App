using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Tutor_Appointments_Core_Web_App.BusinessLayer;

namespace Tutor_Appointments_Core_Web_App.Models
{
    //Connects to the databse and maps model classes
    public class Tutor_Appointments_DBContext : DbContext
    {
        public Tutor_Appointments_DBContext (DbContextOptions<Tutor_Appointments_DBContext> options)
            : base(options)
        {
        }

        public DbSet<Tutor_Appointments_Core_Web_App.BusinessLayer.Appointment> Appointment { get; set; }

        public DbSet<Tutor_Appointments_Core_Web_App.BusinessLayer.Faculty> Faculty { get; set; }

        public DbSet<Tutor_Appointments_Core_Web_App.BusinessLayer.Student> Student { get; set; }

        public DbSet<Tutor_Appointments_Core_Web_App.BusinessLayer.Tutor> Tutor { get; set; }
    }
}
