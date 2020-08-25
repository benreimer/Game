using System;

namespace Game.Menu
{
    class Exit : IMenu
    {
        public string Description => "Exit";
        public void Execute(Game game, Utilities utilities) 
        {
            if(game.Name == null && game.Character == null)
            {
                Environment.Exit(0);
                return;
            }

            Console.WriteLine("You are about to exit, would you like to save your game first? (Y/N)");
            var answer = Console.ReadLine();
            switch (answer)
            {
                case "Y":
                    utilities.LoadMenu(game, utilities, "SaveGame");
                    //todo check to make sure the game was saved correctly and then exit
                    Environment.Exit(0);
                    break;
                case "N":
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }          
        }
    }
}
