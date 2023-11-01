using Microsoft.AspNetCore.Mvc;
using UkazkoveMVC.Models;

namespace UkazkoveMVC.Controllers
{
    public class NasobilkaController : Controller
    {
        public IActionResult Index(int size)
        {
            if(size > 10)
                return BadRequest();

            var nasobilka = new NasobilkaXY(size);

            return View(nasobilka);
        }
    }
}
