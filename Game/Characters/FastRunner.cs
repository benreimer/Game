using System;
using System.Xml.Serialization;
using Game.Weapons;

namespace Game.Characters
{
    [XmlInclude(typeof(Character))]
    [Serializable()]

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
        }
    }
}
