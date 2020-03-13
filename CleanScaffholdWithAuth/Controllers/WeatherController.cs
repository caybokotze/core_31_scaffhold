using System.Linq;
using CleanScaffholdWithAuth.Data;
using Microsoft.AspNetCore.Mvc;

namespace CleanScaffholdWithAuth.Controllers
{
    public class WeatherController : Controller
    {
        private ApplicationDbContext _context;
        public WeatherController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET
        public IActionResult Index()
        {
            return Ok(_context.Users.ToList());
        }
    }
}