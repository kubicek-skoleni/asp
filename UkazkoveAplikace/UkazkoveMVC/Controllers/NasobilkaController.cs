using Microsoft.AspNetCore.Mvc;
using UkazkoveMVC.Models;

namespace UkazkoveMVC.Controllers
{
    public class NasobilkaController : Controller
    {
        public IActionResult Index()
        {
            var nasobilka = new NasobilkaXY(5);

            return View(nasobilka);
        }
    }
}
