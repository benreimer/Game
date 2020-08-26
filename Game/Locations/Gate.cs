using System;
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
                }
            };
            Items = "Item1,Item2,Item3";
            Greeting = "You are at the gate you must catch some fish before the guard will open the gate.";

        }

        public override void DisplayMenu(Game game, Utilities utilities)
        {
            if (game.Character.Knapsack.Items.Contains("Fish"))
            {
                Greeting = "You have given the guard a fish and he has now opened the gate!";
                AvailableDirections.Add(new Direction
                {
                    Value = "East",
                    Destination = "Cabin"
                });
            }
            
            
            Console.WriteLine(Greeting);
            utilities.LoadMenu(game, utilities, GetMenuItems());
        }

        private string GetMenuItems()
        {
            return this.AvailableDirections.Aggregate("", (current, direction) => current + $"{direction.Value},").TrimEnd(',');
        }

      
    }
}