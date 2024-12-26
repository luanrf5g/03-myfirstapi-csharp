using Microsoft.AspNetCore.Mvc;

namespace _02_myfirstapi_c_.Controllers
{
    public class DeviceController : MyFirstApiBaseController
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Author);
        }
    }
}
