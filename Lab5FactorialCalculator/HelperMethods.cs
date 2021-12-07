using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5FactorialCalculator
{
    public class HelperMethods
    {
        public bool ValidateIntInput (string userInput)
        {
            try
            {
                int.Parse(userInput);
                return true;
            }
            catch (FormatException)
            {

                return false;
            }
        }

        // Return the factorial with a for loop
        public long FactorialWithForLoop (int userGivenInteger)
        {
            long factorial = userGivenInteger;
            for (int i = userGivenInteger - 1; i >= 1; i--)
            {
                factorial = factorial * i;
            }
            return factorial;
        }

        // Return the factorial with recursion
        public long FactorialRecursion(int userGivenInteger)
        {
            if (userGivenInteger == 1)
            {
                return 1;
            }
            else
            {
                return userGivenInteger * FactorialRecursion(userGivenInteger - 1);
            }
        }

        // Returns a value to determine if the user would like to continue
        public
            string ContinueAgain(string userInput)
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
