using System;

namespace Game.Menu
{
    class ViewCharacterStats : IMenu
    {
        public string Description => "View Character Stats";
        public void Execute(Game game, Utilities utilities) 
        {
            Console.WriteLine("View Character Stats");
            game.Character.ViewStats();
        }
    }
}
