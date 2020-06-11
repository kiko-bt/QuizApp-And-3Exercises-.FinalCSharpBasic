using System;
using System.Collections.Generic;
using System.Text;

namespace QuizApp.Services
{
    public class HelperServices
    {
        public int ValidatePositiveNumber(string number, int range)
        {
            while (true)
            {
                int result = 0;
                bool isNumber = int.TryParse(number, out result);
                if (!isNumber)
                {
                    Console.WriteLine("You must enter a number. Press enter to try again!");
                    Console.ReadLine();
                    Console.Clear();
                    return -1;
                }
                if (result < 1 || result > range)
                {
                    Console.WriteLine("The number is out of range. Press enter to try again!");
                    Console.ReadLine();
                    Console.Clear();
                    return -1;
                }
                return result;
            }
        }


        public void ErrorMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
