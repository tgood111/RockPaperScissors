using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorLizardSpock
{
    public class Game
    {
        Rules rules;
        Player playerOne;
        Player playerTwo;
        public Game()
        {
            rules = new Rules();
        }
        public void GetNumberOfPlayers()
        {
            Console.WriteLine();
        }

        public void ComparePlayerChoices()
        {
            if (playerOne.choice == playerTwo.choice)
            {
                Console.WriteLine("It was a tie!");
                playerOne.GetRPSLP();
                playerTwo.GetRPSLP();
                ComparePlayerChoices();
            }
            else if (playerOne.choice == "Rock" && playerTwo.choice == "Paper")
            {
                Console.WriteLine(playerTwo.name + " won this round.");
                playerTwo.IncrementScore();
            }
            else if (playerOne.choice == "Rock" && playerTwo.choice == "Scissors")
            {
                Console.WriteLine(playerOne.name + " won this round.");
                playerOne.IncrementScore();
            }
            else if (playerOne.choice == "Rock" && playerTwo.choice == "Lizard")
            {
                Console.WriteLine(playerOne.name + " won this round.");
                playerOne.IncrementScore();
            }
            else if (playerOne.choice == "Rock" && playerTwo.choice == "Spock")
            {
                Console.WriteLine(playerTwo.name + " won this round.");
                playerTwo.IncrementScore();
            }
            else if (playerOne.choice == "Paper" && playerTwo.choice == "Rock")
            {
                Console.WriteLine(playerOne.name + " won this round.");
                playerOne.IncrementScore();
            }
            else if (playerOne.choice == "Paper" && playerTwo.choice == "Scissors")
            {
                Console.WriteLine(playerTwo.name + " won this round.");
                playerTwo.IncrementScore();
            }
            else if (playerOne.choice == "Paper" && playerTwo.choice == "Lizard")
            {
                Console.WriteLine(playerTwo.name + " won this round.");
                playerTwo.IncrementScore();
            }
            else if (playerOne.choice == "Paper" && playerTwo.choice == "Spock")
            {
                Console.WriteLine(playerOne.name + " won this round.");
                playerOne.IncrementScore();
            }
            else if (playerOne.choice == "Scissors" && playerTwo.choice == "Paper")
            {
                Console.WriteLine(playerOne.name + " won this round.");
                playerOne.IncrementScore();
            }
            else if (playerOne.choice == "Scissors" && playerTwo.choice == "Rock")
            {
                Console.WriteLine(playerTwo.name + " won this round.");
                playerTwo.IncrementScore();
            }
            else if (playerOne.choice == "Scissors" && playerTwo.choice == "Lizard")
            {
                Console.WriteLine(playerOne.name + " won this round.");
                playerOne.IncrementScore();
            }
            else if (playerOne.choice == "Scissors" && playerTwo.choice == "Spock")
            {
                Console.WriteLine(playerTwo.name + " won this round.");
                playerTwo.IncrementScore();
            }
            else if (playerOne.choice == "Lizard" && playerTwo.choice == "Rock")
            {
                Console.WriteLine(playerTwo.name + " won this round.");
                playerTwo.IncrementScore();
            }
            else if (playerOne.choice == "Lizard" && playerTwo.choice == "Paper")
            {
                Console.WriteLine(playerOne.name + " won this round.");
                playerOne.IncrementScore();
            }
            else if (playerOne.choice == "Lizard" && playerTwo.choice == "Scissors")
            {
                Console.WriteLine(playerTwo.name + " won this round.");
                playerTwo.IncrementScore();
            }
            else if (playerOne.choice == "Lizard" && playerTwo.choice == "Spock")
            {
                Console.WriteLine(playerOne.name + " won this round.");
                playerOne.IncrementScore();
            }
            else if (playerOne.choice == "Spock" && playerTwo.choice == "Rock")
            {
                Console.WriteLine(playerOne.name + " won this round.");
                playerOne.IncrementScore();
            }
            else if (playerOne.choice == "Spock" && playerTwo.choice == "Paper")
            {
                Console.WriteLine(playerTwo.name + " won this round.");
                playerTwo.IncrementScore();
            }
            else if (playerOne.choice == "Spock" && playerTwo.choice == "Scissors")
            {
                Console.WriteLine(playerOne.name + " won this round.");
                playerOne.IncrementScore();
            }
            else if (playerOne.choice == "Spock" && playerTwo.choice == "Lizard")
            {
                Console.WriteLine(playerTwo.name + " won this round.");
                playerTwo.IncrementScore();
            }
        }

        public void DeterineGameWinner()
        {
                if(playerOne.roundScore == 2)
                {
                Console.WriteLine($"{ playerOne.name} wins the game");
                }
                else if(playerTwo.roundScore == 2)
                {
                Console.WriteLine($"{playerTwo.name} wins");
            }
        }
    //1. display rules
    //2. how many players
    //3. get player names
    //4. make a choice
    //5. Compare choices to determine a round winner
    //6. Give point to round winner
    //7. Check if we have a game winner (if score == 2)
    //8. If we don't have a game winner, rinse and repeat from step 4
    }
}
