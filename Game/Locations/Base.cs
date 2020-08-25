using System.Collections.Generic;
using System.Linq;
using Game.Weapons;

namespace Game.Locations
{
    public class Base: Location
    {
        public int Strength;
        public int Level;
        public Armor.Armor Defense;
        public Weapon Weapons;
        
        public Base()
        {
            Name = "Base";
            AvailableDirections = new List<Direction>
            {
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
            utilities.LoadMenu(game,utilities,GetMenuItems());
        }

        private string GetMenuItems()
        {
            return this.AvailableDirections.Aggregate("", (current, direction) => current + $"{direction.Value},").TrimEnd(',');
        }
    }
}