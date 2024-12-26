using _02_myfirstapi_c_.Communications.Requests;
using _02_myfirstapi_c_.Communications.Responses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

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

        [HttpPost]
        [ProducesResponseType(typeof(ResponseRegisteredUserJson), StatusCodes.Status201Created)]
        public IActionResult Create([FromBody] RequestRegisterUserJson request)
        {
            var response = new ResponseRegisteredUserJson
            {
                Id = 1,
                Name = request.Name
            };

            return Created(string.Empty, response);
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult Update([FromBody] RequestUpdateUserJson request) { return NoContent(); }

        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult Delete() { return NoContent(); }
    }
}
