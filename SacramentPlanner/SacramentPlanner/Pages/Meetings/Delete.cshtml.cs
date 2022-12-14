using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SacramentPlanner.Data;
using SacramentPlanner.Models;

namespace SacramentPlanner.Pages.Meetings
{
    public class DeleteModel : PageModel
    {
        private readonly SacramentPlanner.Data.SacramentPlannerContext _context;

        public DeleteModel(SacramentPlanner.Data.SacramentPlannerContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Meeting Meeting { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Meeting == null)
            {
                return NotFound();
            }

            var speakers = await this._context.Speaker.ToListAsync();
            var meeting = await _context.Meeting.FirstOrDefaultAsync(m => m.Id == id);

            if (meeting == null)
            {
                return NotFound();
            }
            else 
            {
                Meeting = meeting;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Meeting == null)
            {
                return NotFound();
            }
            var speakers = await _context.Speaker.ToListAsync();
            var meeting = await _context.Meeting.FindAsync(id);
            var meeting_speakers = meeting.speakers;

            if (meeting != null)
            {
                Meeting = meeting;
                _context.Meeting.Remove(Meeting);
                foreach (Speaker speaker in meeting_speakers)
                {
                    _context.Speaker.Remove(speaker);
                }
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
