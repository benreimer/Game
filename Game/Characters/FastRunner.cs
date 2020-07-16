using Game.Weapons;

namespace Game.Characters
{
    public class FastRunner: Character
    {
        public FastRunner()
        {
            Class = "FastRunner";
            Health = 100;
            HitPoints = 20;
            MaxSpeed = 100;
            Weapons = new Weapon();
            Armor = new Armor.Armor();
            Coins = 100;
            Level = 1;
            CurrentLocation = 0;
            Knapsack = new Knapsack();
        }
    }
}
