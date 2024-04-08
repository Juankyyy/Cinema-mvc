using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Cinema.Data;
using Cinema.Models;

namespace Cinema.Controllers {
    public class MenusController : Controller 
    {
        public readonly CinemaContext _context;

        public MenusController(CinemaContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Menus.ToListAsync());
        }

        public async Task<IActionResult> Details(int id)
        {
            return View(await _context.Menus.FindAsync(id));
        }

        public async Task<IActionResult> Edit(int id)
        {
            return View(await _context.Menus.FindAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Menu menu)
        {
            _context.Menus.Update(menu);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int id)
        {
            var menu = await _context.Menus.FindAsync(id);

            _context.Menus.Remove(menu);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    } 
}