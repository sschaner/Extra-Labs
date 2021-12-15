using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13RockPaperScissors
{
    public class HelperMethods
    {
        public static void ErrorMessage(string customErrorMessage)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{customErrorMessage}");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
