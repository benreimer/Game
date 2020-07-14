using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Characters
{
    public class HeavyHitter: Character
    {
        public HeavyHitter()
        {
            CharacterClassName = "HeavyHitter";
            Health = 100;
            HitPoints = 60;
            MaxSpeed = 65;
            Weapons = new Weapon();
            Armor = new Armor();
            Knapsack = new Knapsack();
        }
    }
}
