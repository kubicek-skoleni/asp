using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TelefonniSeznam.Data;
using TelefonniSeznam.Models;

namespace TelefonniSeznam.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly SeznamDbContext _context;

        public HomeController(ILogger<HomeController> logger,
                                SeznamDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var model = _context.Lide.ToList();

            return View(model);
        }

        public IActionResult Pridej()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Pridej(Clovek clovek)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _context.Lide.Add(clovek);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}