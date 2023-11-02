using Microsoft.AspNetCore.Mvc;

namespace UkazkoveMVC.Controllers
{
    [Route("[controller]")]
    public class HelloController : Controller
    {
        List<string> people = new List<string>()
        {
            "Pavel",
            "Jana",
            "Martin",
            "Lucie",
            "Veronika",
            "Marcel"
        };
        public IActionResult Index()
        {
            return View();
        }

        public string Person(int id)
        {
            return $"ahoj {people[id]}";
        }

        [Route("[action]/{name}")]
        [HttpGet]
        public string Exists(string name)
        {
            if (people.Contains(name))
            {
                return "známe";
            }
            else
            {
                return "neznáme";
            }
        }
    }
}
