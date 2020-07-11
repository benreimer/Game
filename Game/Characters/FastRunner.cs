using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Characters
{
    public class FastRunner: Character
    {
        public FastRunner()
        {
            CharacterClassName = "FastRunner";
            Health = 100;
            HitPoints = 20;
            MaxSpeed = 100;
            Weapons = new Weapon();
            Armor = new Armor();
        }
    }
}
