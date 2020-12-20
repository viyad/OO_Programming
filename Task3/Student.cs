using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    /// <summary>
    /// Student class - Task 3
    /// Student class inherites name from Person class
    /// It implements its own PrintDetails method (Polymorphism)
    /// Written by: Viyada Tarapornsin
    /// </summary>
    public class Student : Person
    {
        // Attribute that is known by Student objects only
        private string[] _subjects;

        // Add constructor
        public Student(string name, string[] subject) : base(name)
        {
            _subjects = subject;
        }

        // Polymorphism and overloading method
        public override void PrintDetails()
        {
            // Print details to console
            string subjectList = "";

            foreach (string subject in _subjects)
                subjectList += subject + ",";

            subjectList = subjectList.Trim(',');
            Console.WriteLine("Hi my name is " + this._name + " and I am studying " + subjectList);
        }
    }
}
