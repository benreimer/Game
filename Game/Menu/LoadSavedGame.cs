using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Menu
{
    class LoadSavedGame : IMenu
    {
        public string Description => "Load Saved Game";
        public void Execute()
        {
            Console.WriteLine("Load Saved Game menu item");
        }
    }
}
