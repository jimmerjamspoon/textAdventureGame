using System;

namespace TextBasedAdventurGame
{
    class MeadowNode : BaseNode
    {
        protected override void ShowDescription()
        {
            Console.WriteLine("You've entered a lush and green meadow.");
            Console.WriteLine("There is a huge empty nest with four moving unhatched eggs.");
            Console.WriteLine("There is a screech coming from over the distant mountain.");
            Console.WriteLine();
        }

        protected override void ShowOptions()
        {
            Console.WriteLine("Set fire to the nest (f)");
            Console.WriteLine("Chase the dragon into the mountain (c)");
            Console.WriteLine("Pick up an egg (e)");
        }

        protected override BaseNode GetNextNodeInternal(char key)
        {
            switch (key)
            {
                case 'f':
                    return new StartNode();
                case 'w':
                    return new StartNode();
                default:
                    return null;
            }
        }
    }
}
