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
    public class IndexModel : PageModel
    {
        private readonly SacramentPlanner.Data.SacramentPlannerContext _context;

        public IndexModel(SacramentPlanner.Data.SacramentPlannerContext context)
        {
            _context = context;
        }
        [BindProperty(SupportsGet = true)]

        public string SearchString { get; set; }

        [BindProperty(SupportsGet = true)]
        public IList<Meeting> Meeting { get;set; } = default!;

        public async Task OnGetAsync()
        {
            var meetings = from m in _context.Meeting
                         select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                meetings = meetings.Where(s => s.Conductor.Contains(SearchString));
                    //meetings.Where(s => s.Title.Contains(SearchString));
            }
            meetings = meetings.OrderBy(o => o.Date);
            Meeting = await meetings.ToListAsync();
        }
            //if (_context.Meeting != null)
            //{
            //    Meeting = await _context.Meeting.ToListAsync();
            //}
        }
    }

