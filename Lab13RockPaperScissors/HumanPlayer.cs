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
            bool validResponse = false;
            do
            {
                Console.Write("Rock, paper, or scissors? (R/P/S): ");
                string userInput = Console.ReadLine();
                switch (userInput.ToLower().Trim())
                {
                    case "r":
                        validResponse = true;
                        return RPS.rock;
                    case "p":
                        validResponse = true;
                        return RPS.paper;
                    case "s":
                        validResponse = true;
                        return RPS.scissors;
                    default:
                        validResponse = false;
                        Console.WriteLine("Please enter either 'R', 'P', or 'S'.");
                        break;
                }
            } while (validResponse == false);
            return RPS.rock;
        }

    }
}
