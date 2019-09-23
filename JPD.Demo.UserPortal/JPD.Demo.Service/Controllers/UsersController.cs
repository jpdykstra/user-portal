using JPD.Demo.Service.Business;
using JPD.Demo.Service.Data;
using JPD.Demo.Service.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace JPD.Demo.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UserContext _context;

        public UsersController(UserContext context)
        {
            _context = context;
        }

        // GET api/users/john
        [HttpGet("{name}")]
        public ActionResult<IEnumerable<User>> GetByFirstOrLastName(string name)
        {
            var userLogic = new UserLogic(new UserData(_context));

            var users = userLogic.SearchByFirstOrLastName(name);

            if (users == null || users.Count.Equals(0))
            {
                return NotFound();
            }

            return Ok(users);
        }

        // POST api/users
        [HttpPost]
        public IActionResult Post([FromBody] User user)
        {
            if (user == null || !ModelState.IsValid)
            {
                return BadRequest();
            }

            var userLogic = new UserLogic(new UserData(_context));

            userLogic.AddUser(user);

            return Created("A new user was created", user);
        }
    }
}
