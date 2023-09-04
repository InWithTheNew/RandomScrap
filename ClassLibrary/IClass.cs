﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    internal interface IClass
    {
        void AddStudentToClass(Person x);
        void RemoveStudentFromClass(Person student);
        List<Person> GetStudentsFromClass();

    }
}
