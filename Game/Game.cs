using System;
using System.Runtime.InteropServices;
using Game.Characters;

namespace Game
{
    public class Game
    {
        public string Name;
        public Character Character;
        public Base Base;
        public Map Map;
        public Level CurrentLevel;
        public Shop Shop;
        public QuestPath CurrentPath;
        public Utilities Utilities = new Utilities();
        public Battle Battle;

        public void StartNewGame()
        {
            Name = "NEW GAME";
            Console.WriteLine("Starting a new game....");
            Console.WriteLine("");
            Character = Utilities.CreateNewCharacter();
            Base = new Base();
            Battle = new Battle();
            Console.WriteLine("Would you like to Load A Map or start with the Default Map?");
            Map = new Map();
            Map = Map.LoadDefaultMap();

            CurrentLevel = new Level {LevelNumber = 1};
            
            Shop = new Shop();
        }

        public void Play()
        {
            CurrentPath = Map.Paths[0];

            Console.WriteLine("You are now playing the game....add more game elements here...");


            while (this.Character.CurrentLocation < CurrentPath.Length)
            {
                Character.MoveForward(CurrentPath);
                CheckCurrentLocation();
                

            }
            //  while


            Utilities.LoadMenu(this, Utilities, "SaveGameData,ViewCharacterStats,Battle,Exit");
        }

        private void CheckCurrentLocation()
        {
            //check to see if you are at the location of another path
            foreach (AdventurePath path in CurrentPath.PathList)
            {
                //if current location is characters max speed than the path found at this location would be the parent path and I don't want that one so look for others
                if (Character.CurrentLocation > path.Location && Character.CurrentLocation != Character.MaxSpeed)   
                {
                    Console.WriteLine($"You found a new path. What would you like to do?");
                    Utilities.LoadMenu(this,Utilities,"GoBack,KeepOnMoving,TakeNewPath");
                }

                ////check to see if you are back at the "Parent" Quest Path
                //if (path.ParentPath != null && Character.CurrentLocation == path.ParentPath.Location)
                //{
                //    Console.WriteLine($"You are back to {path.ParentPath.Name}. What would you like to do?");
                //    Utilities.LoadMenu(this, Utilities, "GoBack,KeepOnMoving,TakeNewPath");

                //}
                
            }

           



            //check for a weapon of any kind
            if (CurrentPath.Weapon != null)
            {
                if (Character.CurrentLocation > CurrentPath.Weapon.Location && CurrentPath.Weapon?.Found == false)
                {
                    Character.CurrentLocation = CurrentPath.Weapon.Location;
                    CurrentPath.Weapon.Found = true;
                    Console.WriteLine($"You found a {CurrentPath.Weapon.Name}. What would you like to do?");
                    Utilities.LoadMenu(this, Utilities, "PickItUp,KeepOnMoving,GoBack");
                }
            }

            //check for the end of the current patch
            if(Character.CurrentLocation == CurrentPath.Length)
            {
                Console.WriteLine("You made it to the end of the path!");
            }
          
        }
    }
}
