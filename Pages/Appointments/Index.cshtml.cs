﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Tutor_Appointments_Core_Web_App.BusinessLayer;
using Tutor_Appointments_Core_Web_App.Models;

namespace Tutor_Appointments_Core_Web_App.Pages.Appointments
{
    public class IndexModel : PageModel
    {
        private readonly Tutor_Appointments_Core_Web_App.Models.Tutor_Appointments_DBContext _context;

        public IndexModel(Tutor_Appointments_Core_Web_App.Models.Tutor_Appointments_DBContext context)
        {
            _context = context;
        }

        public IList<Appointment> Appointment { get;set; }

        public async Task OnGetAsync()
        {
            Appointment = await _context.Appointment
                .Include(a => a.Student)
                .Include(a => a.Tutor).ToListAsync();
        }
    }
}
