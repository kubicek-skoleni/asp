using Microsoft.AspNetCore.Mvc;
using UkazkoveMVC.Models;

namespace UkazkoveMVC.Controllers
{
    [Route("[controller]")]
    public class NasobilkaController : Controller
    {
        [Route("tabulka/{size}")]
        public IActionResult Tabulka(int size)
        {
            if(size > 10)
                return BadRequest();

            var nasobilka = new NasobilkaXY(size);

            return View(nasobilka);
        }

        [Route("[action]")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
