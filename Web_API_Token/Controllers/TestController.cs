using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Web.Http;

namespace Web_API_Token.Controllers
{
    public class TestController : ApiController
    {


        [Authorize(Roles = "SuperAdmin, Admin, User")]
        [HttpGet]
        [Route("api/test/resource1")]
        public IHttpActionResult GetResource1()
        {
            var identity = (ClaimsIdentity)User.Identity;
            var UserName = identity.Name;
            var clientId = identity.Claims.FirstOrDefault(c => c.Type == "ClientId").Value;
            var clientName = identity.Claims.FirstOrDefault(c => c.Type == "ClientName").Value;
            var clientSecret = identity.Claims.FirstOrDefault(c => c.Type == "ClientSecret").Value;

            return Ok("Hello: " + UserName  + " Client Name: "+clientName);
        }



        [Authorize(Roles = "SuperAdmin, Admin")]
        [HttpGet]
        [Route("api/test/resource2")]
        public IHttpActionResult GetResource2()
        {
            var identity = (ClaimsIdentity)User.Identity;
            var UserName = identity.Name;
            var Email = identity.Claims.FirstOrDefault(c => c.Type == "Email").Value;
            var clientId = identity.Claims.FirstOrDefault(c => c.Type == "ClientID").Value;
            var clientName = identity.Claims.FirstOrDefault(c => c.Type == "ClientName").Value;
            var clientSecret = identity.Claims.FirstOrDefault(c => c.Type == "ClientSecret").Value;

            return Ok("Hello " + UserName + ", Your Email ID is : " + Email + " Client Name: " + clientName);
        }


        [Authorize(Roles = "SuperAdmin")]
        [HttpGet]
        [Route("api/test/resource3")]
        public IHttpActionResult GetResource3()
        {
            var identity = (ClaimsIdentity)User.Identity;
            var roles = identity.Claims.Where(c => c.Type == ClaimTypes.Role).Select(c => c.Value);
            var clientId = identity.Claims.FirstOrDefault(c => c.Type == "ClientID").Value;
            var clientName = identity.Claims.FirstOrDefault(c => c.Type == "ClientName").Value;
            var clientSecret = identity.Claims.FirstOrDefault(c => c.Type == "ClientSecret").Value;
            return Ok("Hello " + identity.Name + " Client Name: " + clientName + " Your Role(s) are: " + string.Join(",", roles.ToList()));
        }
    
}
}
