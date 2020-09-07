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
                //todo  each time I add a new type of location I have to come add it here.   is there a better way of doing this?
                new Base(),
                new Gate(),
                new Lake(),
                new Cabin(),
                new Woods(),
                new Town()
            };
        }
    }
}
