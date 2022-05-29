using System;

namespace TextBasedAdventurGame
{
    class StartNode : BaseNode
    {
        protected override void ShowDescription()
        {
            Console.WriteLine("You have just landed on Earth after travelling through space for decades.");
            Console.WriteLine("You have responded to an emergency beacon.");
            Console.WriteLine("Earth is being terrorised by a naughty dragon that needs slayer.");
            Console.WriteLine();
        }

        protected override void ShowOptions()
        {
            Console.WriteLine("Investiage the area (i)");
            Console.WriteLine("Go south (s)");
            Console.WriteLine("Go west (w)");
        }

        protected override BaseNode GetNextNodeInternal(char key)
        {
            switch (key)
            {
                case 's':
                    return new MeadowNode();
                case 'w':
                    return new DesertNode();
                default:
                    return null;
            }
        }
    }
}
