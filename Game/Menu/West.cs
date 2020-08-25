using System;

namespace Game.Menu
{
    class West: IMenu
    {
        private string direction = "West";
        public string Description => $"Go {direction}";
        public void Execute(Game game, Utilities utilities)
        {
            game.Character.Move(game, direction);            
        }
    }
}
