using System;
using Game.Locations;
using Game.Weapons;

namespace Game.Characters
{
    public class Character
    {
        public string Class;
        public int Health;
        public int HitPoints;
        public int MaxSpeed;
        public int Coins;
        public Weapon Weapons;
        public Knapsack Knapsack;
        public Armor.Armor Armor;
        public int Level;
        public Location CurrentLocation;


        public void ViewStats()
        {
            //is there a way to automatically print out all props of a class without having to update them all here
            Console.WriteLine($"Character Class Name: {Class}");
            Console.WriteLine($"Health: {Health}");
            Console.WriteLine($"Hit Points: {HitPoints}");
            Console.WriteLine($"Max Speed: {MaxSpeed}");
        }

        public void Move(Game game, string directionToMove)
        {
            var a = 1;

            //this needs to be converted to a menu item
            var previousLocation = CurrentLocation;
            

            var nextLocation = CurrentLocation.AvailableDirections.Find(d => d.Value == directionToMove);
            CurrentLocation = game.CurrentPath.LocationList.Find(l => l.Name == nextLocation.Destination);

            Console.WriteLine("Your current location is the " + CurrentLocation.Name);
            CurrentLocation.DisplayMenu(game, new Utilities());

        }
    }
}
