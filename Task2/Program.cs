using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        /// <summary>
        /// Main method - Task 2
        /// Calculating the cost of booking a room
        /// Written by: Viyada Tarapornsin
        /// Note: Validation is not required for this task
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Declare and initialise parallel arrays and variables
            string[] room = { "Single", "Double", "Luxury", "Penthouse" };
            double[] price = { 45.50, 99.99, 165.25, 1095.50 };
            int roomType = 0, night = 0;

            // Disply menu
            Console.WriteLine("Roome Types");
            Console.WriteLine();

            // Iterate through the room array and display the name price of each room
            for (int index = 0; index < room.Length; index++)
                Console.WriteLine("{0}. {1} {2:c} per night", index + 1, room[index], price[index]);

            // Prompt a user to enter a room type
            Console.WriteLine();
            Console.Write("Please select a room type 1, 2, 3 or 4: ");
            roomType = Convert.ToInt32(Console.ReadLine());

            // Prompt the user to enter the number of night
            Console.Write("Please enter the number of night: ");
            night = Convert.ToInt32(Console.ReadLine());

            // Display the result of the calculation
            Console.WriteLine();
            Console.WriteLine("Thank you, the total cost for staying in the {0} room for {1} nights is {2:C}", room[roomType - 1], night, night * price[roomType - 1]);
            Console.ReadLine();
        }
    }
}
