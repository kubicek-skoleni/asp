using Microsoft.AspNetCore.Mvc;

namespace UkazkoveMVC.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
