using System;

namespace Lab6CasinoDiceRoller
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Lab 6: Casino Dice Roller";

            string userInput = "";
            string startGame = "";

            // Display welcome message and ask if they would like to rolle the dice
            Console.Write("Welcome to the Grand Circus Casino! Roll the dice? (y/n): ");
            userInput = Console.ReadLine();
            startGame = userInput;

            if (startGame.ToLower().Trim() == "n")
            {
                Console.WriteLine("Maybe some other day.");
                goto Exit;
            }

            if (startGame.ToLower().Trim() == "y")
            {
                int sidesOfDie = -1;
                bool isValidNumber = false;
                do // Loop to ask the user how many sides
                {
                    // Ask the user to enter the number of sides for a pair of dice
                    Console.Write("How many sides should each die have? ");
                    userInput = Console.ReadLine();
                    isValidNumber = int.TryParse(userInput, out sidesOfDie);
                    if (isValidNumber == false)
                    {
                        Console.WriteLine("Please input a valid number of sides.");
                    }

                } while (isValidNumber == false);

                int rollCount = 1;
                bool rollAgain = false;
                do // Loops as long as the user wants to roll again
                {
                    // Prompt the user to roll the die
                    Console.WriteLine("Press enter to roll the die.");
                    Console.ReadKey();

                    // "roll" two n-sided dice
                    int rollOne = RollDie(sidesOfDie);
                    int rollTwo = RollDie(sidesOfDie);

                    // Display the results of each, telling how many rolls the user has rolled
                    Console.WriteLine($"Roll {rollCount}");
                    Console.WriteLine(rollOne);
                    Console.WriteLine(rollTwo);
                    rollCount++;

                    string rollAgainInput = "";
                    do // Loop for determining if the user wants to roll again
                    {
                        // Ask the user if they would like to roll again
                        Console.Write("Roll again? (y/n): ");
                        userInput = Console.ReadLine();
                        rollAgainInput = userInput;
                        if (rollAgainInput.ToLower().Trim() == "y")
                        {
                            rollAgain = true;
                        }
                        else if (rollAgainInput.ToLower().Trim() == "n")
                        {
                            Console.WriteLine("Thanks for playing. Bye!");
                            rollAgain = false;
                            goto Exit;
                        }
                        else
                        {
                            Console.WriteLine("Please enter either 'y' or 'n'");
                        }
                    } while (rollAgainInput.ToLower().Trim() != "y");

                } while (rollAgain == true);
            }

        Exit:

            Console.ReadKey();
        }

        // Method to roll a die
        public static int RollDie(int sidesOfDie)
        {
            Random random = new Random();
            int dieOne = random.Next(1, sidesOfDie + 1);
            return dieOne;
        }
    }
}
