using JPD.Demo.Service.Common.Enums;
using JPD.Demo.Service.Controllers;
using JPD.Demo.Service.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace JPD.Demo.Tests
{
    [TestClass]
    public class UsersControllerTests : BaseDataTests
    {
        private readonly UsersController _controller;

        public UsersControllerTests()
        {
            _controller = new UsersController(_context);
        }

        [TestMethod]
        public void UsersController_Should_AddUser_MartyMcFly()
        {
            var user = new User()
            {
                FirstName = "Marty",
                LastName = "McFly",
                Age = 42,
                Addresses = new List<Address>(),
                Interests = new List<Interest>()
            };

            user.Addresses.Add(new Address()
            {
                AddressType = AddressType.Mailing,
                AddressLine1 = "9303 Lyon Drive",
                AddressLine2 = "Lyon Estates",
                City = "Hill Valley",
                State = "CA",
                ZipCode = "90001"
            });

            user.Addresses.Add(new Address()
            {
                AddressType = AddressType.Billing,
                AddressLine1 = "9303 Lyon Drive",
                AddressLine2 = "Lyon Estates",
                City = "Hill Valley",
                State = "CA",
                ZipCode = "90001"
            });

            user.Interests.Add(new Interest()
            {
                Name = "Traveling",
                Description = "Are you telling me you built a time machine out of a DeLorean?"
            });

            var response = _controller.Post(user);

            Assert.IsInstanceOfType(response, typeof(CreatedResult));
        }

        [TestMethod]
        public void UsersController_Should_ReturnBadRequest_Post()
        {
            var user = new User()
            {
                FirstName = "",
                LastName = "BadRequest",
                Age = 63,
                Addresses = new List<Address>(),
                Interests = new List<Interest>()
            };

            _controller.ModelState.AddModelError("FirstName", "Required");

            var response = _controller.Post(user);

            Assert.IsInstanceOfType(response, typeof(BadRequestResult));
        }

        [TestMethod]
        public void UsersController_Should_GetByFirstOrLastName_WithJohn()
        {
            var okResult = _controller.GetByFirstOrLastName("john").Result as OkObjectResult;

            Assert.IsInstanceOfType(okResult.Value, typeof(IList<User>));

            Assert.IsTrue((okResult.Value as IList<User>).FirstOrDefault().FirstName.Trim().ToLower().Equals("john"));
        }

        [TestMethod]
        public void UsersController_Should_ReturnOkResult_GetByFirstOrLastName()
        {
            var result = _controller.GetByFirstOrLastName("john");

            Assert.IsInstanceOfType(result.Result, typeof(OkObjectResult));
        }

        [TestMethod]
        public void UsersController_Should_ReturnNotFoundResult_GetByFirstOrLastName()
        {
            var result = _controller.GetByFirstOrLastName("name_not_found");

            Assert.IsInstanceOfType(result.Result, typeof(NotFoundResult));
        }
    }
}
