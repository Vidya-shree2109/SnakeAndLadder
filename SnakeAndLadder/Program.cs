using System;
namespace SnakeAndLadder
{
    class Program
    {
        static void Main(String[] args)
        {
            SnakeAndLadderGame game = new SnakeAndLadderGame();
            Console.WriteLine("The Die rolled number is " + game.DieRoll());
        }
    }
}