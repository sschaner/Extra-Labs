using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4Exponents
{
    public class HelperMethods
    {
        public static string ContinueAgain(string userInput)
        {
            if (userInput.ToLower().Trim() == "y")
            {
                return "yes";
            }
            if (userInput.ToLower().Trim() == "n")
            {
                return "no";
            }
            return "invalid";
        }
    }
}
