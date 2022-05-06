using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderSimulator
{
    public class Snake_Ladder_Simulator
    {
        int Start_Position=0;
        Random getnum = new Random();
        public void DieRoll()
        {
            int num = getnum.Next(1, 7);
            Console.WriteLine(num);
        }
    }
}
