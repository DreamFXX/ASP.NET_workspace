using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovies.Data;
using RazorPagesMovies.Models;

namespace RazorPagesMovies.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesMovies.Data.AppDbContext _context;

        public IndexModel(RazorPagesMovies.Data.AppDbContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; } = default!;

        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }

        public SelectList? Genres { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? MovieGenre { get; set; }

        public async Task OnGetAsync()
        {
            // <snippet_search_linqQuery>
            IQueryable<string> genreQuery = from m in _context.Movie
                                            orderby m.Genre
                                            select m.Genre;
            // </snippet_search_linqQuery>

            var movies = from m in _context.Movie
                         select m;

            if (!string.IsNullOrEmpty(SearchString))
            {
                movies = movies.Where(s => s.Title != null && s.Title.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(MovieGenre))
            {
                movies = movies.Where(x => x.Genre == MovieGenre);
            }

            // <snippet_search_selectList>
            Genres = new SelectList(await genreQuery.Distinct().ToListAsync());
            // </snippet_search_selectList>
            Movie = await movies.ToListAsync();
        }
    }
}
