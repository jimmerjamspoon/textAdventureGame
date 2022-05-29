using System;

namespace TextBasedAdventurGame
{
    abstract class BaseNode
    {
        protected abstract void ShowDescription();
        protected abstract void ShowOptions();
        protected abstract BaseNode GetNextNodeInternal(char key);

        public bool ShouldTheGameEnd { get; internal set; }

        public BaseNode GetNextNode()
        {
            ShowDescription();

            ShowOptions();

            var response = ReadResponse();
            while (response == null)
            {
                response = ReadResponse();
            }

            return response;
        }

        public void ShowInventory()
        {
            Console.WriteLine("Haven't write this yet");
        }

        private BaseNode ReadResponse()
        {
            var response = Console.ReadKey();
            var keyEnteredByUser = response.KeyChar;

            if ( keyEnteredByUser == 'i')
            { 
                ShowInventory();
            }
            else if ( keyEnteredByUser == 'v')
            {
                ShowDescription();
            }

            var nextNode = GetNextNodeInternal(keyEnteredByUser);
            if ( nextNode == null)
                Console.WriteLine("I've no idea what your're pressing but it ain't no option I know about.");

            return nextNode;
        }
    }
}
