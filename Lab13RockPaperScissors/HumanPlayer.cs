using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13RockPaperScissors
{
    public class HumanPlayer : Player
    {
        // Returns the users name
        public static string GetusersName()
        {
            Console.Write("Enter your name: ");
            return Console.ReadLine().Trim();
        }

        // Returns the users choice of rock, paper, or scissors
        public override RPS GenerateRPS()
        {
            RPS playersChoice = RPS.invalid;
            bool validInput = false;
            do
            {
                Console.Write("Rock, paper, or scissors? (R/P/S): ");
                string userInput = Console.ReadLine();
                switch (userInput.ToLower().Trim())
                {
                    case "r":
                        validInput = true;
                        playersChoice = RPS.rock;
                        break;
                    case "p":
                        validInput = true;
                        playersChoice = RPS.paper;
                        break;
                    case "s":
                        validInput = true;
                        playersChoice = RPS.scissors;
                        break;
                    default:
                        validInput = false;
                        HelperMethods.ErrorMessage("Please enter either 'R', 'P', or 'S'.");
                        continue;
                }
            } while (validInput == false);
            return playersChoice;
        }

    }
}
