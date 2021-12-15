using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13RockPaperScissors
{
    public class RandomPlayer : Player
    {
        private readonly Random random = new Random();

        public override RPS GenerateRPS()
        {
            RPS playersChoice = RPS.invalid;
            int randomInt = random.Next(1, 3);
            switch (randomInt)
            {
                case 1:
                    playersChoice = RPS.rock;
                    break;
                case 2:
                    playersChoice = RPS.paper;
                    break;
                default:
                    playersChoice = RPS.scissors;
                    break;
            }
            return playersChoice;
        }
    }
}
