using ConnectionContexts;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Class : IClass
    {
        private string ClassName { get; set; }
        private string RoomName { get; set; }
        private DateTime ClassTime { get; set; }
        private List<Person> Students { get; set; }

        private readonly IPerson _person;

        private readonly IServiceProvider _serviceProvider;

        public Class(IServiceProvider ServiceProvider)
        {
            _serviceProvider = ServiceProvider;
        }

        public Class(IPerson person)
        {
            _person = person;
        }

        public Class(string ClassName)
        {
            this.ClassName = ClassName;
            // Get Class from Database
            new SqlConnection<Person>(_connectionString);
        }

        public void AddStudentToClass(Person student)
        {
            Students.Add(student);
        }

        public void RemoveStudentFromClass(Person student)
        {
            Students.Remove(student);
        }

        public List<Person> GetStudentsFromClass()
        {
            return Students;
        }
    }

}
