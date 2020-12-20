using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        /// <summary>
        /// Main method - Task 3
        /// Create person objects and print their details
        /// Written by: Viyada Tarapornsin
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Declare a Person object
            var people = new List<Person>();

            // Declare and initialize array and variable
            string[] subjects = { "Math", "Science", "English" };
            string studentName = "Sue";

            // Instantiate student and add to people collection
            Person student = new Student(studentName, subjects);
            people.Add(student);
            
            string faculty = "Computer Science";
            string teacherName = "Tim";

            // Instantiate teacher and add to people collection
            Person teacher = new Teacher(teacherName, faculty);
            people.Add(teacher);

            // Iterate through people collection and invoke PrintDetails for each element
            foreach (Person person in people)
            {
                person.PrintDetails();
            }

            people.Clear();
            Console.ReadKey(); 
        }
    }
}
