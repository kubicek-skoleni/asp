using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SkolniRokController : ControllerBase
    {
        [HttpGet("[action]")]
        public DateOnly Zacatek()
        {
            return new DateOnly(2023,9,1);
        }

        [HttpGet("[action]")]
        public DateOnly Konec()
        {
            return new DateOnly(2024, 6, 30);
        }
    }
}
