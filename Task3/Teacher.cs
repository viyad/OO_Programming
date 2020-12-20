using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    /// <summary>
    /// Teacher class - Task 3
    /// Teacher class inherites name from Person class
    /// It implements its own PrintDetails method (Polymorphism)
    /// Written by: Viyada Tarapornsin
    /// </summary>
    public class Teacher : Person
    {
        // Attribute that is known by Teacher objects only
        private string _faculty;

        // Add constructor
        public Teacher(string name, string faculty) : base(name)
        {
            _faculty = faculty;
        }

        // Polymorphism and overloading method
        public override void PrintDetails()
        {
            // Print details to console
            Console.WriteLine("Hi my name is " + this._name + " and I teach in the " + this._faculty + " faculty");
        }
    }
}
