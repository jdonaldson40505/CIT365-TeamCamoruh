using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SacramentPlanner.Data;
using SacramentPlanner.Models;

namespace SacramentPlanner.Pages.Meetings
{
    public class EditModel : PageModel
    {
        private readonly SacramentPlanner.Data.SacramentPlannerContext _context;

        public EditModel(SacramentPlanner.Data.SacramentPlannerContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Meeting Meeting { get; set; } = default!;
        public List<Speaker> Speakers = new List<Speaker>();
        [BindProperty]
        public Speaker Speaker { get; set; }
        public int? numSpeakers;
        public bool success = false;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Meeting == null)
            {
                return NotFound();
            }


            var speakers = await this._context.Speaker.ToListAsync();
            var meeting =  await _context.Meeting.FirstOrDefaultAsync(m => m.Id == id);
            if (meeting == null)
            {
                return NotFound();
            }

            Meeting = meeting;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var speakerNames = ModelState["Speaker.Name"].AttemptedValue;
            var speakerTopics = ModelState["Speaker.Topic"].AttemptedValue;
            if (speakerNames != null && speakerTopics != null)
            {
                String[] names = speakerNames.Split(",");
                String[] topics = speakerTopics.Split(",");
                for (int i = 0; i < names.Length; i++)
                {
                    Speaker speaker = new Speaker();
                    speaker.Name = names[i];
                    speaker.Topic = topics[i];
                    Speakers.Add(speaker);
                }
            }

            Meeting.speakers = Speakers;
            _context.Attach(Meeting).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MeetingExists(Meeting.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool MeetingExists(int id)
        {

            return _context.Meeting.Any(e => e.Id == id);
        }
    }
}
