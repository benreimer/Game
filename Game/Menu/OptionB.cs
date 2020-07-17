using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Menu
{
    class OptionB : IMenu
    {
        public string Description => "OptionB";
        public void Execute()
        {
            Console.WriteLine("Option B menu item");
        }
    }
}
