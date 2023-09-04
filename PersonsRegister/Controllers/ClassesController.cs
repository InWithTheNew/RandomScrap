using Microsoft.AspNetCore.Mvc;
using PersonsRegister.Models;
using RandomGarbLuke;

namespace PersonsRegister.Controllers
{
    [Route("api/v1/")]
    [ApiController]
    public class ClassesController : Controller
    {
        [HttpGet("classes")]
        public string Get()
        {
            return "Classes";
        }
        [HttpPost("classes")]
        public string Post([FromBody] Anything y)
        {
            var x = new Boy(y.Y);
            return "ClassesPost";
        }
    }
}
