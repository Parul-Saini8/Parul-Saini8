using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Fitness_Tracker.Models;

namespace Fitness_Tracker.Pages
{
    public class IndexModel : PageModel
    {
        private readonly FitnessTrackerContext _context;

        public IndexModel(FitnessTrackerContext context)
        {
            _context = context;
        }

        public IList<Craft> Crafts { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        public async Task OnGetAsync()
        {
            IQueryable<Craft> craftsQuery = _context.Crafts;

            if (!string.IsNullOrEmpty(SearchString))
            {
                craftsQuery = craftsQuery.Where(c => c.Name.Contains(SearchString));
            }

            Crafts = await craftsQuery.ToListAsync();
        }
    }
}