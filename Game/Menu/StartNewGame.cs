using System;

namespace Game.Menu
{
    class StartNewGame : IMenu
    {
        public string Description => "Start A New Game";
        public void Execute(Game game, Utilities utilities) 
        {
            Console.WriteLine("Start New Game");
            game.StartNewGame();
            game.Play();
        }
    }
}