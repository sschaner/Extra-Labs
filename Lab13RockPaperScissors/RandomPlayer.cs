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
            int randomInt = random.Next(1, 3);
            switch (randomInt)
            {
                case 1:
                    return RPS.rock;
                case 2:
                    return RPS.paper;
                default:
                    return RPS.scissors;
            }
        }
    }
}
