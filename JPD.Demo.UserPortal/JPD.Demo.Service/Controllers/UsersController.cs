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

        /// <summary>
        /// Searches for users whose first or last name match the name provided.
        /// </summary>
        /// <param name="name">Either the first or last name of a user</param>
        /// <returns>Returns an OKObjectResult with a list of users whose first or last name matches the input (including name, addresses, age, and interests).</returns>
        // GET api/users/john
        [HttpGet("searchbyname/{name}")]
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

        /// <summary>
        /// Adds a new user.
        /// </summary>
        /// <param name="user">User including name, age, addresses and interests.</param>
        /// <returns>Returns a CreatedResult for the new user.</returns>
        // POST api/users
        [HttpPost("add")]
        public IActionResult AddUser([FromBody] User user)
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
