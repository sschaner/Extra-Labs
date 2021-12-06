using System;

namespace Lab5FactorialCalculator
{
    class Program
    {
        /*
         * The application prompts the user to enter an integer from 1 to 10.
         * The application displays the factorial of the number entered by the user.
         * The application prompts the user to continue.
         */
        static void Main(string[] args)
        {
            Console.Title = "Lab 5 - Factorial Calculator";

            string userInput = "";
            int smallestInt = 0;
            int largestInt = 21;
            int userGivenInteger = -1;
            bool validGivenInteger = false;
            bool enterAgain = true;

            Console.WriteLine("Welcome to the Factorial Calculator!\n");

            HelperMethods helper = new HelperMethods();
            do
            {
                do
                {
                    Console.Write($"Enter an integer that's greater than {smallestInt} but less than {largestInt}: ");
                    userInput = Console.ReadLine();
                    
                    bool validInt = helper.ValidateIntInput(userInput);
                    if (validInt == true)
                    {
                        userGivenInteger = int.Parse(userInput);
                    }
                    else
                    {
                        Console.WriteLine("Please enter valid input.");
                        continue;
                    }
                    if (userGivenInteger <= smallestInt || userGivenInteger >= largestInt)
                    {
                        Console.WriteLine($"Your integer must be greater than {smallestInt} but less than {largestInt}.");
                    }
                    else
                    {
                        validGivenInteger = true;
                    }
                } while (validGivenInteger == false);

                //long factorial = HelperMethods.FactorialWithForLoop(userGivenInteger);
                long factorial = helper.FactorialRecursion(userGivenInteger);


                Console.WriteLine($"The factorial of {userGivenInteger} is {factorial}.");

                string continueAgain = "";
                do
                {
                    Console.Write("\nContinue? (y/n): ");
                    userInput = Console.ReadLine();

                    continueAgain = helper.ContinueAgain(userInput);
                    if (continueAgain == "no")
                    {
                        goto Exit;
                    }
                    else if (continueAgain == "invalid")
                    {
                        Console.WriteLine("Please enter either 'y' or 'n'.");
                    }
                } while (continueAgain == "invalid");
            } while (enterAgain == true);

            Exit:
            Console.WriteLine("Goodbye!");

            Console.ReadKey();
        }
    }
}
