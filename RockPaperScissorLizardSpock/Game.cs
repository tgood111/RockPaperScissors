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
