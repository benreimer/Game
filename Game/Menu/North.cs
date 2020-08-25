using System;

namespace Game.Menu
{
    class North: IMenu
    {
        private string direction = "North";
        public string Description => $"Go {direction}";
        public void Execute(Game game, Utilities utilities)
        {
            //Console.WriteLine("Go North");
            game.Character.Move(game,direction);            
        }
    }
}
