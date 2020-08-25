using System;

namespace Game.Menu
{
    class GoBack: IMenu
    {
        public string Description => "Go back to previous location";
        public void Execute(Game game, Utilities utilities)
        {
            Console.WriteLine("Go back...");
            game.Character.MoveBackward(game.CurrentPath);            
        }
    }
}
