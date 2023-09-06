using ConnectionContexts;
using Entities;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;
using PersonsRegister.Services;

namespace PersonsRegister.Controllers
{
    [Route("api/v1/simple")]
    [ApiController]
    public class SimpleController : Controller
    {

        [HttpGet("say-hi")]
        public string Get()
        {
            return "Eyyyy lad, what's up?";
        }

        [HttpPost("add-numbers")]
        public int Post([FromBody] Numbers x)
        {
            return x.AddNumbers();
        }

    }
}
