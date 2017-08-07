using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorLizardSpock
{
    public class Player
    {
       public int roundScore;
       public string name;
       public string choice;
        public List<string> MoveList = new List<string>() { "Rock", "Paper", "Scissors", "Lizard", "Spock" };
    
    public Player()
    {

    }
    public void IncrementScore()
        {
            roundScore++;
        }
        public virtual void GetRPSLP()
        { 
        
            Console.WriteLine("Choose between: Rock, Paper, Scissor, Lizard, Spock.");
             choice = (Console.ReadLine());
            switch (choice)
            {
                case "Rock":
                    Console.WriteLine("Rock");
                    break;
                case "Paper":
                    Console.WriteLine("Paper");
                    break;
                case "Scissors":
                    Console.WriteLine("Scissors");
                    break;
                case "Lizard":
                    Console.WriteLine("Lizard");
                    break;
                case "Spock":
                    Console.WriteLine("Spock");
                    break;
            }
            
        }
    }
}
