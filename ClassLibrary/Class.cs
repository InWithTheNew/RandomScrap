using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    internal class Class : IClass
    {
        private string ClassName { get; set; }
        private string RoomName { get; set; }
        private DateTime ClassTime { get; set; }
        private List<Person> Students { get; set; }

        public Class(string ClassName, I)
        {
            this.ClassName = ClassName;
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
