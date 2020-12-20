using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    /// <summary>
    /// Person class - Task 3
    /// Person class is the base class of Student and Teacher classes
    /// Written by: Viyada Tarapornsin
    /// </summary>
    public abstract class Person
    {
        // Attribute that will inherites to its children 
        protected string _name;

        // Constructor
        public Person(){}

        // Constructor with passing name value
        public Person(string name)
        {
            // Initialise _name field
            _name = name;
        }

        // Abstract method
        // To allow children class print details differently (Polymorphism)
        public abstract void PrintDetails(); 
    }
}
