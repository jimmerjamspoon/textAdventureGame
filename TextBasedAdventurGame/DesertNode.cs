using System;

namespace TextBasedAdventurGame
{
    class DesertNode : BaseNode
    {
        protected override void ShowDescription()
        {
            Console.WriteLine("You've wandered into an arid and waterless desert.");
            Console.WriteLine("You ran out of water and died.");
            Console.WriteLine("Better luck next time!");
            Console.WriteLine();

            base.ShouldTheGameEnd = true;
        }

        protected override void ShowOptions()
        {
        }

        protected override BaseNode GetNextNodeInternal(char key)
        {
            return null;
        }
    }
}
