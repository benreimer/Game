using System.Collections.Generic;
using System.Linq;

namespace Game.Locations
{
    public class Lake : Location
    {
        public Lake()
        {
            Name = "Lake";
            AvailableDirections = new List<Direction>
            {
                new Direction
                {
                    Value = "South",
                    Destination = "Gate"
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