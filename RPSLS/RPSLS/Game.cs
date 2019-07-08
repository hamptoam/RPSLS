using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {

        public const int MAX_SCORE = 3;

        //member variables (HAS A)
        public Player player1;
        public Player player2;
        public string player1Move;
        public string player2Move;



        //member construct



        //member methods 
        public void RunGame()
        {
            choosePlayers();

            while (player1.score < MAX_SCORE && player2.score < MAX_SCORE)
            {
                player1Move = player1.ChooseMove();
                player2Move = player2.ChooseMove();
                winnerandLoser();

                if (player1.score == MAX_SCORE || player2.score == MAX_SCORE)
                {
                    string winningPlayerName = "";
                    if (player1.score == MAX_SCORE)
                    {
                        winningPlayerName = player1.name;
                    }
                    else
                    {
                        winningPlayerName = player2.name;
                    }

                    Console.WriteLine(winningPlayerName + " wins!");
                    Console.WriteLine("Enter 1 to play again, 2 to quit.");
                    string choice = Console.ReadLine();

                    if (choice == "1")
                    {
                        player1.score = 0;
                        player2.score = 0;
                    }
                    else
                    {
                        // Loop will stop.
                    }
                }
                else
                {
                    Console.WriteLine(player1.name + ": " + player1.score + " v " + player2.name + ": " + player2.score);
                    Console.WriteLine("Press enter for next round...");
                    Console.ReadLine();
                }
            }
        }
        public void choosePlayers()
        {
            string oneOrTwoPlayers;
            Console.WriteLine("Rock Paper Scissors Lizard Spock!");
            Console.WriteLine("Do you have one or two players?");
            oneOrTwoPlayers = Console.ReadLine();
            switch (oneOrTwoPlayers)
            {
                case "1":
                    player1 = new Human("");
                    Console.WriteLine("Please enter your name");
                    Console.ReadLine();
                    player2 = new AI("Larry");
                    break;

                case "2":
                    
                    Console.WriteLine("Please enter player 1 name.");
                    string player1Name = Console.ReadLine();
                    Console.WriteLine("Please enter player 2 name.");
                    string player2Name = Console.ReadLine();
                    player1 = new Human(player1Name);
                    player2 = new Human(player2Name);
                    break;
            }

        }

        public void winnerandLoser()
        {
        
            if (player1Move == "Rock")
            {
                if (player2Move == "Rock")
                {
                    //tie next round 
                    Console.WriteLine("Players tie!");
                }

                if (player2Move == "Paper")
                {
                    Console.WriteLine("Paper Covers Rock!");
                    player2.score++; 
                }

                if (player2Move == "Scissors")
                {
                    Console.WriteLine("Rock Smashes Scissors!");
                    player1.score++;
                }
                if (player2Move == "Lizard")
                {
                    Console.WriteLine("Rock Crushes Lizard!");
                    player1.score++;
                }
                if (player2Move == "Spock")
                {
                    Console.WriteLine("Spock Vaporizes Rock!");
                    player2.score++;
                }
            }
            if (player1Move == "Paper")
            {
                if (player2Move == "Rock")
                {
                    Console.WriteLine("Paper Covers Rock!");
                    player1.score++;
                }

                if (player2Move == "Paper")
                {
                    Console.WriteLine("Players tie!");
                    //tie
                }
                if (player2Move == "Scissors")
                {
                    Console.WriteLine("Scissors Cut Paper!");
                    player2.score++;
                }
                if (player2Move == "Lizard")
                {
                    Console.WriteLine("Lizard Eats Paper!");
                    player2.score++;
                }
                if (player2Move == "Spock")
                {
                    Console.WriteLine("Paper Disproves Spock!");
                    player1.score++;
                }
            }
            if (player1Move == "Scissors")
            {
                if (player2Move == "Rock")
                {
                    Console.WriteLine("Rock Smashes Scissors!");
                    player2.score++;
                }
                if (player2Move == "Paper")
                {
                    Console.WriteLine("Scissors Cuts Paper!");
                    player1.score++;
                }
                if (player2Move == "Scissors")
                {
                    Console.WriteLine("Players tie!");
                    //tie
                    
                }
                if (player2Move == "Lizard")
                {
                    Console.WriteLine("Scissors Decapitates Lizard!");
                    player1.score++;
                }
                if (player2Move == "Spock")
                {
                    Console.WriteLine("Spock Breaks Scissors!");
                    player2.score++;
                }
            }
            if (player1Move == "Lizard")
            {
                if (player2Move == "Rock")
                {
                    Console.WriteLine("Rock Smashes Lizard!");
                    player2.score++;
                }
                if (player2Move == "Paper")
                {
                    Console.WriteLine("Lizard Eats Paper!");
                    player1.score++;
                }
                if (player2Move == "Scissors")
                {
                    Console.WriteLine("Scissors Decapitates Lizard!");
                    player2.score++;
                }
                if (player2Move == "Lizard")
                {
                    Console.WriteLine("Players tie!");
                    //tie
                }
                if (player2Move == "Spock")
                {
                    Console.WriteLine("Lizard Poisons Spock!");
                    player1.score++;
                }
            }
            if (player1Move == "Spock")
            {
                if (player2Move == "Rock")
                {
                    Console.WriteLine("Spock Vaporizes Rock!");
                    player1.score++;
                }
                if (player2Move == "Paper")
                {
                    Console.WriteLine("Paper Disproves Spock!");
                    player2.score++;
                }
                if (player2Move == "Scissors")
                {
                    Console.WriteLine("Spock Breaks Scissors!");
                    player1.score++;
                }
                if (player2Move == "Lizard")
                {
                    Console.WriteLine("Lizard Poisons Spock!");
                    player2.score++;
                }
                if (player2Move == "Spock")
                {
                    Console.WriteLine("Players tie!");
                    //tie
                }
            }
        }
    }
}