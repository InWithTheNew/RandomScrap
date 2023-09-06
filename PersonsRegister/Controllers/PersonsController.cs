using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Threading.Tasks;
using ConnectionContexts;
using Entities;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace PersonsRegister.Controllers
{
    [Route("api/v1/persons")]
    [ApiController]
    public class PersonsController : Controller
    {
        private readonly ISqlConnectionFactory _sqlConnectionFactory;

        public PersonsController(ISqlConnectionFactory sqlConnectionFactory)
        {
            _sqlConnectionFactory = sqlConnectionFactory ?? throw new ArgumentNullException(nameof(sqlConnectionFactory));
        }

        //[HttpGet("{stringy}")]
        //public string Get(string stringy)
        //{
        //    return stringy;
        //}

        [HttpGet("{Id}")]

        public async Task<Person> Get(Guid? Id)
        {
            var s = _sqlConnectionFactory.PersonsConnection();

            var person = await s.Persons.FindAsync(Id);
            return person;
        }

        public async Task<Person> Get([FromBody] Guid Id)
        {
            var s = _sqlConnectionFactory.PersonsConnection();

            var person = await s.Persons.FindAsync(Id);
            return person;
        }

        [HttpGet("search/{surname}")]

        public List<Person> Get(string surname)
        {
            var s = _sqlConnectionFactory.PersonsConnection();
            var person = s.Persons.Where(x => x.Surname == surname).ToList() ;
            //var list = person.Select(s => new { s.Id, s.FirstName }).ToList();

            //return person.Select(u => new Person()
            //{
            //    FirstName = u.FirstName,
            //    Surname = u.Surname,
            //    Dob = u.Dob,
            //    Gender = u.Gender,
            //    Height = u.Height,
            //    Weight = u.Weight,


            //});

            return person;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Person x)
        {
            // save person to db
            var s = _sqlConnectionFactory.PersonsConnection();
            try
            {
                await s.Persons.AddAsync(x);
                s.SaveChanges();
                return StatusCode((int)System.Net.HttpStatusCode.Accepted);
            } catch (Exception ex)
            {
                Console.WriteLine(ex);
                return StatusCode((int)System.Net.HttpStatusCode.InternalServerError);
            }
            
        }
    }
}
