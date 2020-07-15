using System;
using System.Xml.Serialization;
using Game.Weapons;

namespace Game.Characters
{
    [XmlInclude(typeof(Character))]
    [Serializable()]

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
            CurrentLocation = 0;
        }
    }
}
