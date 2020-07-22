using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Menu
{
    class PickItUp : IMenu
    {
        public string Description => "Pick It Up";
        public void Execute(Game game, Utilities utilities)
        {

            Console.WriteLine($"You picked up the {game.CurrentPath.Weapon.Name}");
            game.Character.Knapsack.Weapons.Add(game.CurrentPath.Weapon);
        }
    }
}
