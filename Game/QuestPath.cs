using System.Collections.Generic;
using Game.Locations;

namespace Game
{
    public class QuestPath
    {
        //public string Name;
        //public int Length;
        public List<Location> LocationList;
        //public Weapon Weapon;
       // public List<AdventurePath> PathList = new List<AdventurePath>();


        public QuestPath()
        {
            LocationList = new List<Location>
            {
                new Base(),
                new Cabin(),
                new Woods(),
                new Town()
            };
        }
    }
}
