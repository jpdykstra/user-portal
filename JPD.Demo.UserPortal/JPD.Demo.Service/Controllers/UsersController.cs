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

        // GET api/users
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            var userData = new UserData(_context);

            string[] names;
            names = "Evan Garcia".Split();

            var users = userData.SearchByNames(names);

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

            var userData = new UserData(_context);

            userData.AddUser(user);

            return Created("A new user was created", user);
        }
    }
}
