using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Cinema.Data;
using Cinema.Models;

using Cinema.Helpers;
using Cinema.Providers;
using Microsoft.AspNetCore.Http;

namespace Cinema.Controllers
{
    public class MoviesController : Controller
    {
        public readonly CinemaContext _context;
        private readonly HelperUploadFiles helperUploadFiles;

        public MoviesController(CinemaContext context, HelperUploadFiles helperUpload)
        {
            _context = context;
            this.helperUploadFiles = helperUpload;
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

        public IActionResult Upload()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Upload(Movie movie, IFormFile file, int path)
        {
            string nameFile = file.FileName;
            string pathFile = "";

            switch(path)
            {
                case 0:
                    pathFile = await this.helperUploadFiles.UploadFilesAsync(file, nameFile, Folders.Images);
                    break;
                
                case 1:
                    pathFile = await this.helperUploadFiles.UploadFilesAsync(file, nameFile, Folders.Documents);
                    break;
                
                // case 2:
                //     pathFile = await this.helperUploadFiles.UploadFilesAsync(file, nameFile, Folders.Downloads);
                //     break;
            }

            movie.Image = nameFile;
            _context.Movies.Add(movie);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}