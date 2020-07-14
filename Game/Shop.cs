using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Weapons;

namespace Game
{
    [Serializable()]
    public class Shop
    {
        public List<Weapon> AvailableWeapons;
        public List<Armor.Armor> AvailableArmor;
        public Food AvailableFood;

    }
}
