using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Tutor_Appointments_Core_Web_App.BusinessLayer;
using Tutor_Appointments_Core_Web_App.Models;

namespace Tutor_Appointments_Core_Web_App.Pages.Faculties
{
    public class DetailsModel : PageModel
    {
        private readonly Tutor_Appointments_Core_Web_App.Models.Tutor_Appointments_DBContext _context;

        public DetailsModel(Tutor_Appointments_Core_Web_App.Models.Tutor_Appointments_DBContext context)
        {
            _context = context;
        }

        public Faculty Faculty { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Faculty = await _context.Faculty.FirstOrDefaultAsync(m => m.Id == id);

            if (Faculty == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
