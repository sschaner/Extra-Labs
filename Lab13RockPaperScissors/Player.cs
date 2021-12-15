using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13RockPaperScissors
{
    public abstract class Player
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int numberOfWins;
        public int NumberOfWins
        {
            get { return numberOfWins; }
            set { numberOfWins = value; }
        }

        public abstract RPS GenerateRPS();
    }
}
