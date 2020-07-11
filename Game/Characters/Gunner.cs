using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Characters
{
    public class Gunner: Character
    {
        public Gunner()
        {
            CharacterClassName = "Gunner";
            Health = 100;
            HitPoints = 45;
            MaxSpeed = 85;
            Weapons = new Weapon();
            Armor = new Armor();
        }
    }
}
