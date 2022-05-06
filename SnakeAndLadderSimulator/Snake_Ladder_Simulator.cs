using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderSimulator
{
    public class Snake_Ladder_Simulator
    {
        int Start_Position = 0;
        public const int No_Play = 0;
        public const int Ladder = 1;
        public const int Snake = 2;

        Random getnum = new Random();
        public void checkForOptions()
        {
            int die = getnum.Next(1, 7);
            Console.WriteLine(die);
            
            int option=getnum.Next(0,3);
            Console.WriteLine("Option:"+option);
            switch(option)
            {
                case No_Play:
                    Start_Position = 0;
                    Console.WriteLine("Current Position of player is "+Start_Position);
                    break;
                    
                case Ladder:
                    Start_Position += die ;
                    Console.WriteLine("Current Position of player is "+Start_Position);
                    break;
                case Snake:
                    Start_Position -= die ;
                    Console.WriteLine("Current Position of player is " + Start_Position);
                    break ;
                default:
                    Console.WriteLine("Wrong Choice");
                    break;
            }
        }
    }
}