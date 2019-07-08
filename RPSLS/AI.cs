using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class AI : Player
    {
        //member variables



        //constructor 

        public AI(string name) : base(name)
        {
            this.name = name;
        }


        //methods


        List<string> actions = new List<string>()
        { "Rock", "Paper", "Scissors", "Lizard", "Spock" };

        public override string ChooseMove()

        {
            Random Rand = new Random();
            int RandomNumber = Rand.Next(0, 4);


            return actions[RandomNumber];
        }
    }
} 
