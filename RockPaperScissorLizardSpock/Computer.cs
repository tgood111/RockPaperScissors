using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorLizardSpock
{
    public class Computer: Player
    {
        Random random = new Random();
        public Computer()
        {

        }
        public override void GetRPSLP()
        {        
            choice = MoveList[random.Next(0, MoveList.Count)];
        }
    }
  
}
