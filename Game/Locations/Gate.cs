using System.Collections.Generic;
using System.Linq;

namespace Game.Locations
{
    public class Gate : Location
    {
        public Gate()
        {
            Name = "Gate";
            AvailableDirections = new List<Direction>
            {
                new Direction
                {
                    Value = "North",
                    Destination = "Lake"
                },
                new Direction
                {
                    Value = "West",
                    Destination = "Base"
                },
                new Direction
                {
                    Value = "East",
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