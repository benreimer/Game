﻿using Game.Weapons;

namespace Game.Characters
{
    public class Mercenary: Character
    {
        public string Tribe;

        public Mercenary()
        {
            Class = "Mercenary";
            Health = 100;
            HitPoints = 20;
            MaxSpeed = 100;
            Weapons = new Weapon();
            Armor = new Armor.Armor();
            Coins = 100;
            Level = 1;
            Tribe = "Orthog";
            CurrentLocation = 0;
        }
    }
}
