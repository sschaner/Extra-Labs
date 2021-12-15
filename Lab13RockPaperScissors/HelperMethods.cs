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

        public static bool YesOrNo(string userInput)
        {
            bool playAgain = false;
            switch (userInput.ToLower().Trim())
            {
                case "y":
                    playAgain = true;
                    break;
                case "n":
                    playAgain = false;
                    break;
                default:
                    HelperMethods.ErrorMessage("Please enter either 'y' or 'n'.");
                    break;
            }
            return playAgain;
        }
    }
}
