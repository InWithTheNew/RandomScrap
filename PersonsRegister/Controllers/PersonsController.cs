using Microsoft.AspNetCore.Mvc;
using PersonsRegister.Models;
using RandomGarbLuke;

namespace PersonsRegister.Controllers
{
    [Route("api/v1/")]
    [ApiController]
    public class PersonsController : Controller
    {
        [HttpGet("persons")]
        public string Get()
        {
            //return "Welcome";
            var x = new Boy(150);
            return x.GetHeightinCM().ToString();
        }
        [HttpPost]
        public string Post([FromBody] Anything y)
        {
            var x = new Boy(y.Y);
            return x.GetHeightinCM().ToString();
        }
    }
}
