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
            Console.WriteLine("How many players? 1 or 2");
            int numberOfPlayers = int.Parse(Console.ReadLine());
            if (numberOfPlayers == 1)
            {
                playerOne = new Human();
                playerTwo = new Computer();
                playerOne.name = GetPlayerName();
                playerTwo.name = GetPlayerName();
            }
            else if (numberOfPlayers == 2)
            {
                playerOne = new Human();
                playerTwo = new Human();
                playerOne.name = GetPlayerName();
                playerTwo.name = GetPlayerName();
            }
            else
            {
                Console.WriteLine("Please choose 1 or 2");
                GetNumberOfPlayers();
            }

        }
        public string GetPlayerName()
        {
            Console.WriteLine("Enter player name");
            string name = Console.ReadLine();
            return name;
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

        public void DetermineGameWinner()
        {
            if (playerOne.roundScore == 2)
            {
                Console.WriteLine($"{ playerOne.name} wins the game");
            }
            else if (playerTwo.roundScore == 2)
            {
                Console.WriteLine($"{playerTwo.name} wins");
            }
        }
        public void RunGame()
        {
            rules.DisplayRules();
            GetNumberOfPlayers();
            while (playerOne.roundScore < 2 && playerTwo.roundScore < 2)
            {
                ComparePlayerChoices();
                DetermineGameWinner();
            }
            AskPlayAgain();
            }
            public void AskPlayAgain()
        {
            Console.WriteLine("Play again? yes or no");
            string userInput = Console.ReadLine();
            if (userInput.ToLower() == "yes")
            { 
                
                    RunGame();
                }
                else
                {
                    Console.WriteLine("Thanks for playing!");
                    Environment.Exit(0);
              
            }
        }
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