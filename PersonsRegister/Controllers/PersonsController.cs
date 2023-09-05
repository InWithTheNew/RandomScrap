using System;
using Entities;
using Microsoft.AspNetCore.Mvc;
using PersonsRegister.Models;

namespace PersonsRegister.Controllers
{
    [Route("api/v1/")]
    [ApiController]
    public class PersonsController : Controller
    {
        //[HttpGet("persons")]
        //public string Get(Guid personId)
        //{
        //    //return "Welcome";
        //    //var x = new Boy(150);
        //    //return x.GetHeightinCM().ToString();
        //}

        [HttpPost]
        public string Post([FromBody] Person x)
        {
            // save person to db

            return x.GetHeightinCM().ToString();
        }
    }
}
