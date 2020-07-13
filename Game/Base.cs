using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Weapons;
using Game.Armor;

namespace Game
{
    [Serializable()]
    public class Base
    {
        public int Level;
        public Armor.Armor Defense;
        public Weapon Weapons;
    }
}
