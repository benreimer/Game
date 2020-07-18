using System;

namespace Game.Menu
{
    class Battle : IMenu
    {
        public string Description => "Battle";
        public void Execute(Game game, Utilities utilities)
        {
            Console.WriteLine("Fight a Battle with your character");
            game.Battle.Fight(game.Character);          
        }
    }
}