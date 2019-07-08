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

        public AI(string name) : base (name)
        {
            this.name = name; 
        }


        //methods


        List<string> actions = new List<string>();

        public void initializeActions()
        {
            actions.Add("Rock");
            actions.Add("Paper");
            actions.Add("Scissors");
            actions.Add("Lizard");
            actions.Add("Spock");
        }

        public override string ChooseMove()
            
        {
            Random Rand = new Random();
            int RandomNumber = Rand.Next(0, 5);


            return actions[RandomNumber];

        }

    }
}
