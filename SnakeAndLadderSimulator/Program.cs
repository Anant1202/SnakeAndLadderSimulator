using System;

namespace SnakeAndLadderSimulator
{
    public  class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake & Ladder Simulator Program");
            Snake_Ladder_Simulator ob1= new Snake_Ladder_Simulator();
            ob1.DieRoll();
        }
    }
}

