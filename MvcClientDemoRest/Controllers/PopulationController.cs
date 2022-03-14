using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MvcClientDemoRest.Models;
using System;

namespace MvcClientDemoRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PopulationController : ControllerBase
    {
        [HttpGet()]
        public PopulationInfo Get()
        {
            var random = new Random();
            return new PopulationInfo
            {
                Males = random.Next(100),
                Females = random.Next(100),
                Others = random.Next(100),
                Below18 = random.Next(100),
                Above65 = random.Next(100),
            };
        }

        [HttpPost]
        public StatusInfo AuthorizeUser(UserInfo userInfo)
        {
            //// Add Customer
            ///
            
            if(userInfo.UserName == "raman" && userInfo.Password == "gujral@123")
                return new StatusInfo { Success = true, Message = "You are welcome" };
            
            return new StatusInfo { Success = false, Message = "Invalid username and/or password" };
        }
    }

    public class StatusInfo
    {
        public bool Success { get; set; }
        public string Message { get; set; }
    }

    public class UserInfo
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }

    public class Customer
    {
        public string name { get; set; }
        public DateTime dateOfBirth { get; set; }
        public double startingBalance { get; set; }
    }
}
