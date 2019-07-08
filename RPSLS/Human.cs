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

        public Human(string name) : base(name)
        {
            this.name = name;
        }
        //member methods 
        public override string ChooseMove()
        {
            do

            {
                Console.WriteLine(name + ": Enter either Rock, Paper, Scissors, Lizard, or Spock");
                //Console.ReadLine(

                chosenGesture = Console.ReadLine();

                if (chosenGesture != "Rock" && chosenGesture != "Paper" && chosenGesture != "Scissors" && chosenGesture != "Lizard" && chosenGesture != "Spock")
                {
                    Console.WriteLine("You know what you did."); 
                }

            }

            while (chosenGesture != "Rock" && chosenGesture != "Paper" && chosenGesture != "Scissors" && chosenGesture != "Lizard" && chosenGesture != "Spock");
        // how to pick move as human

            return chosenGesture;
        }

    }
}
