using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Human : Player
    {

        //member variables 
        

        //constructor

        public Human(string name) : base (name)
        { 
            this.name= name; 
        }
        //member methods 
        public override string ChooseMove()
        {
        // how to pick move as human
         Console.WriteLine(name +": Enter either Rock, Paper, Scissors, Lizard, or Spock");
         //Console.ReadLine(
    
         chosenGesture = Console.ReadLine();

            return chosenGesture;
        }

    }
}
