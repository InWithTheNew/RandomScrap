using Microsoft.AspNetCore.Mvc;

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
        public string Post()
        {
            var x = new Boy();
            return "ClassesPost";
        }
    }
}
