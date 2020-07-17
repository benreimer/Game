using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Menu
{
    class StartNewGame : IMenu
    {
        public string Description => "Start A New Game";
        public void Execute() 
        {
            Console.WriteLine("Start A New Game menu item");
        }
    }
}
