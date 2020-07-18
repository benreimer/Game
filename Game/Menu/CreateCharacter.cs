using System;

namespace Game.Menu
{
    class CreateCharacter : IMenu
    {
        public string Description => "Create Character";
        public void Execute(Game game, Utilities utilities) 
        {
            Console.WriteLine("Create Charater menu item");
        }
    }
}
