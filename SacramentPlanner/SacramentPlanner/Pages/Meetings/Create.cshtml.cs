using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SacramentPlanner.Data;
using SacramentPlanner.Models;

namespace SacramentPlanner.Pages.Meetings
{
    public class CreateModel : PageModel
    {
        private readonly SacramentPlanner.Data.SacramentPlannerContext _context;

        public CreateModel(SacramentPlanner.Data.SacramentPlannerContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Meeting Meeting { get; set; }
        public List<Speaker> Speakers = new List<Speaker>();
        [BindProperty]
        public Speaker Speaker { get; set; }
        public int? numSpeakers;
        public bool success = false;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsyncCreate()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }
            //foreach(var speaker in ModelState.)
            var speakerNames = ModelState["Speaker.Name"].AttemptedValue;
            var speakerTopics = ModelState["Speaker.Topic"].AttemptedValue;
            if (speakerNames != null && speakerTopics != null)
            {
                String[] names = speakerNames.Split(",");
                String[] topics = speakerTopics.Split(",");
                for(int i = 0; i < names.Length; i++)
                {
                    Speaker speaker = new Speaker();
                    speaker.Name = names[i];
                    speaker.Topic = topics[i];
                    Speakers.Add(speaker);
                }
            }
           
       
          Meeting.speakers = Speakers;
            _context.Meeting.Add(Meeting);
            //_context.Speaker.Add(Speaker);
            await _context.SaveChangesAsync();
            return RedirectToPage("./Index");
        }
         
        public void OnPostChangeSpeakers(int? numSpeakers)
        {
            this.numSpeakers = numSpeakers;
        }
    }
}
