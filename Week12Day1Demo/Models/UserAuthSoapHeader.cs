using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Protocols;

namespace Week12Day1Demo.Models
{
    public class UserAuthSoapHeader : SoapHeader
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public bool IsValid()
        {
            // This is hardcoded for testing
            // In real application, this would be checked in database
            // or using any authentication libraries
            return Username == "raman" && Password == "gujral@123";
        }
    }
}