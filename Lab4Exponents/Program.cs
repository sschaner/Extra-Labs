using System;

namespace Lab4Exponents
{
    class Program
    {
        /*
         * The application prompts the user to enter an integer.
         * The application dispalys a table of squares and cubes from 1 to the value entered.
         * The application prompts the user to continue.
         */
        static void Main(string[] args)
        {
            Console.Title = "Lab 4 - Exponents";

            string userInput = "";
            string column1Title = "Number";
            string column2Title = "Squared";
            string column3Title = "Cubed";
            bool enterAgain = true;

            Console.WriteLine("Learn your squares and cubes!\n");

            do
            {
                Console.Write("Enter an integer: ");
                userInput = Console.ReadLine();
                int userInteger = int.Parse(userInput);

                Console.WriteLine("{0,-10}{1,-10}{2,-10}", column1Title, column2Title, column3Title);
                Console.WriteLine("{0,-10}{1,-10}{2,-10}", "======", "=======", "=====");
                for (int i = 1; i <= userInteger; i++)
                {
                    int number = i;
                    double squared = Math.Pow(i, 2);
                    double cubed = Math.Pow(i, 3);
                    Console.WriteLine("{0,-10}{1,-10}{2,-10}", number, squared, cubed);
                }

                string continueAgain = "";
                do
                {
                    Console.Write("\nContinue? (y/n): ");
                    userInput = Console.ReadLine();

                    continueAgain = HelperMethods.ContinueAgain(userInput);
                    if (continueAgain == "no")
                    {
                        goto Exit;
                    }
                    else if (continueAgain == "invalid")
                    {
                        Console.WriteLine("Please enter either 'y' or 'n'.");
                    }
                } while (continueAgain == "invalid" );
                

            } while (enterAgain == true);
            
            Exit:
            Console.WriteLine("Goodbye!");

            Console.ReadKey();
        }
    }
}
