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
    
    public Player()
    {

    }
    public void IncrementScore()
        {
            roundScore++;
        }
        public virtual void GetRPSLP()
        { 
        
            Console.WriteLine("Choose between: Rock, Paper, Scissor, Lizard, Spock");
             choice = (Console.ReadLine());
            
        }
    }
}
