using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        /// <summary>
        /// Main method - Task 5
        /// display the numbers 50 down to 25 with following conditions:
        /// •	If the number is a multiple of 3, display[3] on the right-side of the number.
        /// •	If the number is a multiple of 5, display[5] on the right-side of the number.
        /// •	If the number is a multiple of 3 and 5, display[3 - 5] on the right-side of the number.
        /// Written by: Viyada Tarapornsin
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Declare and initialise variable
            string message = "";

            // Loop from 50 to 25
            // Display relevant message
            for (int i = 50; i >= 25; i--)
            {
                message = "";

                // Divide the number by 3 and 5
                if (i % 3 == 0) message = "[3]";
                if (i % 5 == 0) message = "[5]";
                if (i % 3 == 0 && i % 5 == 0) message = "[3 & 5]";

                Console.WriteLine("{0} {1}", i, message);
            }
            Console.ReadLine();
        }
    }
}
