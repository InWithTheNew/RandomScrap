using System;
using System.Threading.Tasks;
using ConnectionContexts;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace PersonsRegister.Controllers
{
    [Route("api/v1/")]
    [ApiController]
    public class PersonsController : Controller
    {
        private readonly ISqlConnectionFactory _sqlConnectionFactory;

        public PersonsController(ISqlConnectionFactory sqlConnectionFactory)
        {
            _sqlConnectionFactory = sqlConnectionFactory ?? throw new ArgumentNullException(nameof(sqlConnectionFactory));
        }

        //[HttpGet("persons")]
        //public string Get(Guid personId)
        //{
        //    //return "Welcome";
        //    //var x = new Boy(150);
        //    //return x.GetHeightinCM().ToString();
        //}

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Person x)
        {
            // save person to db
            var s = _sqlConnectionFactory.CreatePersonsConnection();
            await s.Entities.AddAsync(x);

            return StatusCode((int)System.Net.HttpStatusCode.Accepted);
        }
    }
}
