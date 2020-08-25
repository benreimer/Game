using Game.Locations;
using Game.Weapons;

namespace Game.Characters
{
    public class HeavyHitter : Character
    {
        public HeavyHitter()
        {
            Class = "HeavyHitter";
            Health = 100;
            HitPoints = 60;
            MaxSpeed = 65;
            Weapons = new Weapon();
            Armor = new Armor.Armor();
            Coins = 100;
            Level = 1;
            Knapsack = new Knapsack();
            CurrentLocation = new Base();
        }
    }
}
