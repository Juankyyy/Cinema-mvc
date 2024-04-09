using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Cinema.Data;
using Cinema.Models;

namespace Cinema.Controllers
{
    public class MoviesController : Controller
    {
        public readonly CinemaContext _context;

        public MoviesController(CinemaContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Movies.ToListAsync());
        }

        public async Task<IActionResult> Details(int id)
        {
            return View(await _context.Movies.FindAsync(id));
        }

        public async Task<IActionResult> Edit (int id)
        {
            return View(await _context.Movies.FindAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Movie movie)
        {
            _context.Movies.Update(movie);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(Movie movie)
        {
            _context.Movies.Remove(movie);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Movie movie)
        {
            _context.Movies.Add(movie);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public IActionResult Search(string search)
        {
            var movies = _context.Movies.AsQueryable();

            if (!string.IsNullOrEmpty(search))
            {
                movies = movies.Where(m => m.Name.Contains(search));
            }

            return View("Index", movies.ToList());
        }
    }
}