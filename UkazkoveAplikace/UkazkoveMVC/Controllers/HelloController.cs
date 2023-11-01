using Microsoft.AspNetCore.Mvc;

namespace UkazkoveMVC.Controllers
{
    public class HelloController : Controller
    {
        public string Index()
        {
            return "hello world";
        }
    }
}
