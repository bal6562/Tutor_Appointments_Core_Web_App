using System;
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
    public class DeleteModel : PageModel
    {
        private readonly Tutor_Appointments_Core_Web_App.Models.Tutor_Appointments_DBContext _context;

        public DeleteModel(Tutor_Appointments_Core_Web_App.Models.Tutor_Appointments_DBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Appointment Appointment { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Appointment = await _context.Appointment
                .Include(a => a.Student)
                .Include(a => a.Tutor).FirstOrDefaultAsync(m => m.Id == id);

            if (Appointment == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Appointment = await _context.Appointment.FindAsync(id);

            if (Appointment != null)
            {
                _context.Appointment.Remove(Appointment);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
