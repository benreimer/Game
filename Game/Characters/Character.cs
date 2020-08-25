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
        //public int CurrentLocation;
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


            //this will eventually have a timer or something to control character movement along the path
            //for now just increment them 
            //   CurrentLocation += MaxSpeed;

            //if(CurrentLocation > path.Length)
            //{         
            //    CurrentLocation = path.Length;
            //}

            // if (CurrentLocation > 50)
            // {
            //     Console.WriteLine("You found 200 Coins. They have been added to your inventory.");
            //     Coins += 200;
            //  }
        }

        public void MoveForward(QuestPath path)
        {
         //   CurrentLocation += MaxSpeed;

            //if (CurrentLocation > path.Length)
            //{
            //    CurrentLocation = path.Length;
            //}
        }


        public void MoveBackward(QuestPath path)
        {
           // CurrentLocation -= MaxSpeed;

           // if (CurrentLocation < 0)
           // {
             //   CurrentLocation = 0;
          //  }
        }

       
    }
}
