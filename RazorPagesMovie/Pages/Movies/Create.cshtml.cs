using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesMovie.Data;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Pages.Movies
{
    public class CreateModel : PageModel
    {
        private readonly RazorPagesMovieContext _context;

        public CreateModel(RazorPagesMovieContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Movie Movie { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Movie.Add(Movie);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");

            //var EmptyMovie = new Movie();
            //if (await TryUpdateModelAsync<Movie>(EmptyMovie, "Movie", m=>m.Title,
            //    m=>m.ReleaseDate, m => m.Genre, m => m.Price, m => m.Rating))
            //{
            //    _context.Movie.Add(EmptyMovie);
            //    await _context.SaveChangesAsync();
            //    return RedirectToPage("./Index");
            //}
            //return Page();
        }
    }
}
