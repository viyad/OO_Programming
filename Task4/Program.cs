using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        /// <summary>
        /// Main method - Task 4
        /// Read characters from characters file. Count the number of each character occurance
        /// Write to 'character-count.txt' file
        /// Written by: Viyada Tarapornsin
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Read the file as one string.
            /* If charaters.txt file is in the same folder with this program, 
             * uncomment code line 25 and comment code line 26 */
            //string text = File.ReadAllText(@"..\..\characters.txt");
            string text = File.ReadAllText("characters.txt");
            int[] alp = new int[Convert.ToInt32('Z') + 1]; //[text.Length];

            // Iterate through all letters read from text file
            foreach (char symbol in text)
            {
                // Iterate through each alphabetic character [A-Z]
                for (char letter = 'A'; letter <= 'Z'; letter++)
                {
                    // If the letter read from file matched with current letter
                    // increment 1 to the array of that letter
                    if (symbol == letter) alp[letter]++;  
                }
            }

            // Open file and overwrite into file without expanding the content
            /* If character-count.txt file is in the same folder with this program, 
             * uncomment code line 46 and comment code line 45 */
            using (StreamWriter file =
            new StreamWriter("character-count.txt", false))
            //new StreamWriter(@"..\..\character-count.txt", false))
            {
                // Iterate through alphabetic charater[A-Z]
                // Write the letter with the number of its occurance into file
                for (char letter = 'A'; letter <= 'Z'; letter++)
                    file.WriteLine("{0} {1}", letter, alp[letter]);

            }
        }
    }
}
