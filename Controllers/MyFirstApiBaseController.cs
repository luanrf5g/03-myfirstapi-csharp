using Microsoft.AspNetCore.Mvc;

namespace _02_myfirstapi_c_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class MyFirstApiBaseController : ControllerBase
    {
        public string Author { get; set; } = "Luan";

        [HttpGet("heathy")]
        public IActionResult Heathy()
        {
            return Ok("it's working");
        }
    }
}
