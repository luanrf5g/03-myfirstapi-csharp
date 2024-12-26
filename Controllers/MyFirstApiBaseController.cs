using Microsoft.AspNetCore.Mvc;

namespace _02_myfirstapi_c_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyFirstApiBaseController : ControllerBase
    {
        public string Author { get; set; } = "Luan";
    }
}
