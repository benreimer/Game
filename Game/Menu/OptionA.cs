using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Menu
{
    class OptionA : IMenu
    {
        public string Description => "Option A";
        public void Execute()
        {
            Console.WriteLine("Option A menu item");
        }
    }
}
