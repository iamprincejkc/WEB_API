using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_API_Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Camps : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { Moniker ="2018",Name="JKC"});
        }
    }
}
