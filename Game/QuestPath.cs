using Game.Weapons;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Game
{
    public class QuestPath
    {
        public string Name;
        public int Length;
        public Weapon Weapon;


        public QuestPath(string name, int length)
        {
            Name = name;
            Length = length;
            Weapon = new Weapon
            {
                Name = "Knife",
                Damage = 200,
                Location = 125
            };
        }
    }
}
