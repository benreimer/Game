using System;

namespace Game.Menu
{
    class South: IMenu
    {
        private string direction = "South";
        public string Description => $"Go {direction}";
        public void Execute(Game game, Utilities utilities)
        {
            Console.WriteLine("Go South");
            game.Character.Move(game,direction);            
        }
    }
}
