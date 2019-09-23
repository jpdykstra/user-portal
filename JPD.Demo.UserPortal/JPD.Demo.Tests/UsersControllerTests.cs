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
        [TestMethod]
        public void UsersController_Should_GetByFirstOrLastName_WithJohn()
        {
            var controller = new UsersController(_context);

            var okResult = controller.GetByFirstOrLastName("john").Result as OkObjectResult;

            Assert.IsInstanceOfType(okResult.Value, typeof(IList<User>));

            Assert.IsTrue((okResult.Value as IList<User>).FirstOrDefault().FirstName.Trim().ToLower().Equals("john"));
        }

        [TestMethod]
        public void UsersController_Should_ReturnOkResult_GetByFirstOrLastName()
        {
            var controller = new UsersController(_context);

            var result = controller.GetByFirstOrLastName("john");

            Assert.IsInstanceOfType(result.Result, typeof(OkObjectResult));
        }

        [TestMethod]
        public void UsersController_Should_ReturnNotFoundResult_GetByFirstOrLastName()
        {
            var controller = new UsersController(_context);

            var result = controller.GetByFirstOrLastName("name_not_found");

            Assert.IsInstanceOfType(result.Result, typeof(NotFoundResult));
        }
    }
}
