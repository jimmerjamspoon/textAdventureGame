using System;

namespace TextBasedAdventurGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mason's Text Based Adventure Game!");
            Console.WriteLine("Your goal is to kill the dragon");
            Console.WriteLine("At any time press (i) to see your inventory");

            BaseNode currentNode = new StartNode();
            while ( currentNode.ShouldTheGameEnd == false)
            {
                currentNode =  currentNode.GetNextNode();
            }

            Console.WriteLine("You have finished the game!");
        }
    }
}
