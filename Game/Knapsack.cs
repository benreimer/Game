using Game.Weapons;
using System.Collections.Generic;

namespace Game
{
    public class Knapsack
    {
        public int Level;
        public int MaxItems;
        public List<Weapon> Weapons;

        public Knapsack()
        {
            Weapons = new List<Weapon>();
       
        }
    }
}