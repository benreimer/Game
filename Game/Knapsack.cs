using Game.Weapons;
using System.Collections.Generic;
using System.Linq;

namespace Game
{
    public class Knapsack
    {
        public int Level;
        public int MaxItems;
        public List<Weapon> Weapons;
        public List<string> Items;
        public int Coins;

        public Knapsack()
        {
            Coins = 100;
            Items = "Fishing pole,".Split(',').ToList();
            Weapons = new List<Weapon>();

       
        }
    }
}