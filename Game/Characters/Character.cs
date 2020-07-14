using System;
using Game.Weapons;

namespace Game.Characters
{
    [Serializable()]
    public class Character
    {
        public string CurrentLocation;
        public string Class;
        public int Health;
        public int HitPoints;
        public int MaxSpeed;
        public int Coins;
        public Weapon Weapons;
        public Knapsack Knapsack;
        public Armor.Armor Armor;
        public int Level;

        public void ViewStats()
        {
            Console.WriteLine($"Character Class Name: {Class}");
            Console.WriteLine($"Health: {Health}");
            Console.WriteLine($"Hit Points: {HitPoints}");
            Console.WriteLine($"Max Speed: {MaxSpeed}");
        }
    }
}
