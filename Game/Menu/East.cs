using System;

namespace Game.Menu
{
    class East: IMenu
    {
        private string direction = "East";
        public string Description => $"Go {direction}";
        public void Execute(Game game, Utilities utilities)
        {
            game.Character.Move(game,direction);            
        }
    }
}
