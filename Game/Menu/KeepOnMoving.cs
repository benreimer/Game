using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Menu
{
    class KeepOnMoving: IMenu
    {
        public string Description => "Keep On Moving";
        public void Execute(Game game, Utilities utilities)
        {
            Console.WriteLine("Keep on moving...");
            game.Character.Move(game.CurrentPath);            
        }
    }
}
