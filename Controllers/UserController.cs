using Microsoft.AspNetCore.Mvc;

namespace _02_myfirstapi_c_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        [Route("{id}")]
        [ProducesResponseType(typeof(User), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        public IActionResult GetById([FromRoute] int id)
        {
            var response = new User
            {
                Id = 1,
                Age = 23,
                Name = "Luan"
            };

            return Ok(response);
        }
    }
}
