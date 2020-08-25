using System;

namespace Game.Menu
{
    class EnterCabin: IMenu
    {
        public string Description => "Enter Cabin";
        public void Execute(Game game, Utilities utilities)
        {
            Console.WriteLine("Enter Cabin....");

            
            utilities.LoadMenu(game,utilities,"");
            
            //game.Character.Move(game.CurrentPath);            
        }
    }
}



