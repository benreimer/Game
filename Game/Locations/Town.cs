using System.Collections.Generic;
using System.Linq;

namespace Game.Locations
{
    public class Town: Location
    {
        public Town()
        {
            Name = "Town";
            AvailableDirections = new List<Direction>
            {
                new Direction
                {
                    Value = "South",
                    Destination = "Cabin"
                }
            };
            Items = "Item1,Item2,Item3";
        }

        public override void DisplayMenu(Game game, Utilities utilities)
        {
            utilities.LoadMenu(game, utilities, GetMenuItems());
        }

        private string GetMenuItems()
        {
            return this.AvailableDirections.Aggregate("", (current, direction) => current + $"{direction.Value},").TrimEnd(',');
        }

      
    }
}