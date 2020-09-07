using System;
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
            Greeting = "You are at the Lake. You can go fishing if you have a fishing pole.";
        }

        public override void DisplayMenu(Game game, Utilities utilities)
        {
            Console.WriteLine(Greeting);
            Console.WriteLine("You have caught a fish!");
            game.Character.Knapsack.Items.Add("Fish");

            utilities.LoadMenu(game, utilities, GetMenuItems());

        }

        private string GetMenuItems()
        {
            return this.AvailableDirections.Aggregate("", (current, direction) => current + $"{direction.Value},").TrimEnd(',');
        }

      
    }
}