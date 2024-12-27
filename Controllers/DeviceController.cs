using System.Linq.Expressions;
using _02_myfirstapi_c_.Entities;
using Microsoft.AspNetCore.Mvc;

namespace _02_myfirstapi_c_.Controllers
{
    public class DeviceController : MyFirstApiBaseController
    {
        [HttpGet]
        public IActionResult Get()
        {
            var laptop = new Laptop();
            var model = laptop.GetModel();
            var brand = laptop.GetBrand();

            object device = new
            {
                brand,
                model
            };

            return Ok(device);
        }
    }
}
