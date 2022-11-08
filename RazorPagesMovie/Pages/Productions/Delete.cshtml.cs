using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Data;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Pages.Productions
{
    public class DeleteModel : PageModel
    {
        private readonly RazorPagesMovie.Data.RazorPagesMovieContext _context;

        public DeleteModel(RazorPagesMovie.Data.RazorPagesMovieContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Production Production { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Production == null)
            {
                return NotFound();
            }

            var production = await _context.Production.FirstOrDefaultAsync(m => m.Id == id);

            if (production == null)
            {
                return NotFound();
            }
            else 
            {
                Production = production;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Production == null)
            {
                return NotFound();
            }
            var production = await _context.Production.FindAsync(id);

            if (production != null)
            {
                Production = production;
                _context.Production.Remove(Production);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
