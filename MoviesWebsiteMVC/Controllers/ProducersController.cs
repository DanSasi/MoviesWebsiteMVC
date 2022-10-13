using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoviesWebsiteMVC.Data;

namespace MoviesWebsiteMVC.Controllers
{
    public class ProducersController : Controller
    {
        private readonly AppDbContext _context;

        public ProducersController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allProducters = await _context.Producers.ToListAsync();
            return View(allProducters);
        }
    }
}
