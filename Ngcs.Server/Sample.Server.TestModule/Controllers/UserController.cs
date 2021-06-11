using System;
using System.Collections.Generic;
using System.Web.Http;
using Sample.Data.Contracts;

namespace Sample.Server.TestModule.Controllers
{
    public class UserController : ApiController
    {
        public UserController()
        {
        }

        [HttpPost]
        [Route("~/api/User/AddUser")]
        public void AddUser(UserDto userDto)
        {
            var userRepo = new List<UserDto>();
            userRepo.Add(userDto);
        }

        [HttpGet]
        [Route("~/api/User/GetUsers")]
        public UserDto[] GetUsers()
        {
            return new[]
            {
                new UserDto
                {
                    FirstName = "aaaa",
                    LastName = "bbb"
                }
            };
        }
    }
}
