using System.Collections.Generic;

namespace Game.Locations
{
    public class Location
    {
        //this is a location on a path in the game

        public string Name { get; set; }

        //for now I am just setting this up as a string but eventually this will be a list of different types of items
        public string Items { get; set; } 

        public List<Direction> AvailableDirections { get; set; }


        public virtual void DisplayMenu(Game game, Utilities utilities) { }
    }
}