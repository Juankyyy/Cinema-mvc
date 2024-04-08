using Microsoft.AspNetCore.Mvc;
using Cinema.Data;
using Microsoft.EntityFrameworkCore;

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
    }
}