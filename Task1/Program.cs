using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        /// <summary>
        /// Main method - Task 1
        /// Processing a mathematical expression on two integer values with a single operator
        /// Written by: Viyada Tarapornsin
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Declare and initialize variables
            int integer1 = 0, integer2 = 0, result = 0;
            char operatorSign = ' ';
            string sign = "";

            // Prompt user to enter an integer
            // If the input is not valid, ask the user to reenter an integer
            integer1 = GetInteger("Enter an integer value: ");

            // Prompt the user to enter an operator
            // It can be -, +, * or / sign
            // If the input is not valid, ask the user to reenter a valid sign
            operatorSign = GetOperatorSign();

            // Prompt the user to enter another integer
            // If the input is not valid, ask the user to reenter an integer
            integer2 = GetInteger("Enter another integer value: ");

            // Check the operation and perform mathematical calculation based on the input operation
            result = CalculateResult(operatorSign, integer1, integer2, ref sign);

            // Display result on screen in the console
            Console.Write("{0} {1} {2} equals {3}", integer1, sign, integer2, result);
            Console.ReadLine();
        }

        /// <summary>
        /// Prompt user to enter an integer
        /// If the input is not valid, ask the user to reenter an integer
        /// </summary>
        /// <param name="message"></param>
        /// <returns>An integer</returns>
        static int GetInteger(string message)
        {
            // Declare and initialize variables
            bool isValid = true;
            int integer = 0;

            do
            {
                // Prompt user to enter an integer
                Console.Write(message);

                // Validate the input, the input must be an integer
                if (int.TryParse(Console.ReadLine(), out integer))
                {
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("Input is not an integer! Please try again.");
                    isValid = false;
                }
            } while (!isValid);

            return integer;
        }

        /// <summary>
        /// Prompt the user to enter an operator
        /// It can be -, +, * or / sign
        /// If the input is not valid, ask the user to reenter a valid sign
        /// </summary>
        /// <returns>An elementary arithmetic operation</returns>
        static char GetOperatorSign()
        {
            // Declare and initialize variables
            bool isValid = true; 
            char operatorSign = ' ';

            do
            {
                // Prompt the user to enter an operator
                Console.Write("Enter an operator [ Subtract - , Plus + , Multiply * or Division / ]: ");

                // Validate the input, the input must be -, +, *, or /
                if (char.TryParse(Console.ReadLine(), out operatorSign))
                {
                    if (operatorSign != '-' && operatorSign != '+' &&
                        operatorSign != '*' && operatorSign != '/')
                        isValid = false;
                    else
                        isValid = true;
                }
                else
                {
                    isValid = false;
                }

                if (!isValid)
                    Console.WriteLine("Input is not an elementary arithmetic operation! Please try again.");

            } while (!isValid);

            return operatorSign;
        }

        /// <summary>
        /// Check the operation and perform mathematical calculation based on the input operation
        /// </summary>
        /// <param name="operatorSign"></param>
        /// <param name="integer1"></param>
        /// <param name="integer2"></param>
        /// <param name="sign"></param>
        /// <returns>An elementary arithmetic operation</returns>
        static int CalculateResult(char operatorSign, int integer1, int integer2, ref string sign)
        {
            // Declare and initialize variable
            int result = 0;

            // Check the operation and perform mathematical calculation based on the input operation
            switch (operatorSign)
            {
                case '-':
                    sign = "minus";
                    result = integer1 - integer2;
                    break;
                case '+':
                    sign = "plus";
                    result = integer1 + integer2;
                    break;
                case '*':
                    sign = "times";
                    result = integer1 * integer2;
                    break;
                case '/':
                    sign = "divided by";
                    // If the divisor is 0, inform the user that it is not valid
                    if (integer2 == 0) sign = "[zero (0) is not a valid divisor]";
                    else result = integer1 / integer2;
                    break;
                default:
                    sign = "invalid sign";
                    break;
            }

            return result;
        }
    }
}
