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
            CharacterClassName = "Gunner";
            Health = 100;
            HitPoints = 45;
            MaxSpeed = 85;
            Weapons = new Weapon();
            Armor = new Armor.Armor();
        }
    }
}
