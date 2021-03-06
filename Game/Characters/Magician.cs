﻿using Game.Weapons;

namespace Game.Characters
{
    public class Magician: Character
    {
        public int EffectiveRange;

        public Magician()
        {
            Class = "FastRunner";
            Health = 100;
            HitPoints = 20;
            MaxSpeed = 100;
            Weapons = new Weapon();
            Armor = new Armor.Armor();
            Coins = 100;
            Level = 1;
            EffectiveRange = Level * 5;
            CurrentLocation = 0;
        }
    }
}
