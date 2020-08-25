using Game.Locations;
using Game.Weapons;

namespace Game.Characters
{
    public class Gunner: Character
    {
        public Gunner()
        {
            Class = "Gunner";
            Health = 100;
            HitPoints = 45;
            MaxSpeed = 85;
            Weapons = new Weapon();
            Armor = new Armor.Armor();
            Coins = 100;
            Level = 1;
            Knapsack = new Knapsack();
            CurrentLocation = new Base();
        }
    }
}
