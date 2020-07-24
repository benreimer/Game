using Game.Weapons;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Game
{
    public class QuestPath
    {
        public string Name;
        public int Length;
        public int Location;
        public Weapon Weapon;
        public List<AdventurePath> PathList = new List<AdventurePath>();


        public QuestPath(string name, int length)
        {
            Name = name;
            Length = length;
            PathList.Add(new AdventurePath { Name = "NewPath", Length = 125, Location = 100 });
           
        }
    }
}
