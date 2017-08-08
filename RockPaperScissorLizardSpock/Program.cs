using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorLizardSpock
{
    class Program
    {
        static void Main(string[] args)
        {
            Rules ruleSet = new Rules();
            ruleSet.DisplayRules();
            Console.ReadLine();
            Game game = new Game();
            game.RunGame();
        }
    }
}
