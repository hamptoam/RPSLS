using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public abstract class Player
    {   //member variables
        public string name;
        public string chosenGesture;
        public int score; 
        //constructor

        public Player(string name)
        {
            this.name = name;
        }

        //member methods
        abstract public string ChooseMove();


    }
}
