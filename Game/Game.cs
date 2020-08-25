using System;
using System.IO;
using Game.Characters;
using Game.Locations;
using Newtonsoft.Json;

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


            //setup the game path

            QuestPath path = new QuestPath();
            //Direction toCabin = new Direction
            //{
            //    Value = "East",
            //    Destination = "Cabin"
            //};
            //Direction toTown = new Direction
            //{
            //    Value = "North",
            //    Destination = "Town"
            //};
            //Direction toWoods = new Direction
            //{
            //    Value = "South",
            //    Destination = "Woods"
            //};
            //Direction toBase = new Direction
            //{
            //    Value = "West",
            //    Destination = "Base"
            //};
            //Direction woodsToCabin = new Direction
            //{
            //    Value = "North",
            //    Destination = "Cabin"
            //};
            //Direction townToCabin = new Direction
            //{
            //    Value = "South",
            //    Destination = "Cabin"
            //};

            //Location location1 = new Location
            //{
            //    Name = "Base",
            //    AvailableDirections = new List<Direction> { toCabin },
            //    Items = "Item1,Item2,Item3"
            //};

            //Location location2 = new Location
            //{
            //    Name = "Cabin",
            //    AvailableDirections = new List<Direction> { toBase, toTown, toWoods },
            //    Items = "Item1,Item2,Item3"
            //};

            //Location location3 = new Location
            //{
            //    Name = "Woods",
            //    AvailableDirections = new List<Direction> { woodsToCabin },
            //    Items = "Item1,Item2,Item3"
            //};
            //Location location4 = new Location
            //{
            //    Name = "Town",
            //    AvailableDirections = new List<Direction> { townToCabin },
            //    Items = "Item1,Item2,Item3"
            //};


            //path.LocationList = new List<Location> { location1, location2, location3, location4 };


            string output = JsonConvert.SerializeObject(path);
            string outputFile = $@"{Utilities.GetPath()}\PathData.json";
            File.WriteAllText(outputFile, output);


            var fileName = $@"{Utilities.GetPath()}\PathData.json";
            using (StreamReader reader = new StreamReader(fileName))
            {
                string json = reader.ReadToEnd();
                CurrentPath = JsonConvert.DeserializeObject<QuestPath>(json);
            }
            //end setup the game path


            Character = Utilities.CreateNewCharacter();

          //  Character.CurrentLocation = location1;   //location1 is the base
          //  Base = new Base();
          //  Battle = new Battle();
          //  Console.WriteLine("Would you like to Load A Map or start with the Default Map?");
           // Map = new Map();
          //  Map = Map.LoadDefaultMap();

            CurrentLevel = new Level {LevelNumber = 1};
            
            Shop = new Shop();
        }

        public void Play()
        {
           // CurrentPath = Map.Paths[0];

            Console.WriteLine("You are now playing the game....add more game elements here...");


            //   GetDirectionChoices();
            Character.CurrentLocation.DisplayMenu(this, Utilities);

            //while (this.Character.CurrentLocation < CurrentPath.Length)
            //{
            //    Character.MoveForward(CurrentPath);
            //    CheckCurrentLocation();


            //}
            //  while


            Utilities.LoadMenu(this, Utilities, "SaveGameData,ViewCharacterStats,Battle,Exit");
        }

        private void GetDirectionChoices()
        {
            string availableDirections = "";

            if (Character.CurrentLocation.Name == "Base")
            {
                Console.WriteLine("You are currently at your base.  Would you like to take the path to the East? [yes/no]");
                var ans = Console.ReadLine();
                if (ans == "yes")
                {
                    MoveToNextLocation("Base","East");
                }
                else
                {
                    Character.CurrentLocation.DisplayMenu(this,Utilities);
                }
            }

           //foreach (Direction direction in Character.CurrentLocation.AvailableDirections)
           //{
           //    availableDirections += $"{direction.Value},";
           //}

           //availableDirections = availableDirections.TrimEnd(',');  //can I replace this with string.join of the list of values
           //Console.WriteLine($"You can go in the following directions: {availableDirections}");
        }

        private void MoveToNextLocation(string currentLocation, string directionToMove)
        {
            //this needs to be converted to a menu item
            var previousLocation = Character.CurrentLocation;

            
            var nextLocation = Character.CurrentLocation.AvailableDirections.Find(d => d.Value == directionToMove);
            Character.CurrentLocation = CurrentPath.LocationList.Find(l => l.Name == nextLocation.Destination);

            Console.WriteLine("Your current location is the " + Character.CurrentLocation.Name);
            Character.CurrentLocation.DisplayMenu(this,Utilities);
            //ShowLocationMenu();   //todo use something line Character.CurrentLocation.LoadMenu instead

        }
        
        private void ShowLocationMenu()
        {
            Console.WriteLine($"You are now at {Character.CurrentLocation.Name}");
            Console.WriteLine("Here are the menu items for this location....");
        }

        //private void CheckCurrentLocation()
        //{
        //    //check to see if you are at the location of another path
        //    foreach (AdventurePath path in CurrentPath.PathList)
        //    {
        //        //if current location is characters max speed than the path found at this location would be the parent path and I don't want that one so look for others
        //        if (Character.CurrentLocation > path.Location && Character.CurrentLocation != Character.MaxSpeed)   
        //        {
        //            Console.WriteLine($"You found a new path. What would you like to do?");
        //            Utilities.LoadMenu(this,Utilities,"GoBack,KeepOnMoving,TakeNewPath");
        //        }

        //        ////check to see if you are back at the "Parent" Quest Path
        //        //if (path.ParentPath != null && Character.CurrentLocation == path.ParentPath.Location)
        //        //{
        //        //    Console.WriteLine($"You are back to {path.ParentPath.Name}. What would you like to do?");
        //        //    Utilities.LoadMenu(this, Utilities, "GoBack,KeepOnMoving,TakeNewPath");

        //        //}
                
        //    }

           



        //    //check for a weapon of any kind
        //    //if (CurrentPath.Weapon != null)
        //    //{
        //    //    if (Character.CurrentLocation > CurrentPath.Weapon.Location && CurrentPath.Weapon?.Found == false)
        //    //    {
        //    //        Character.CurrentLocation = CurrentPath.Weapon.Location;
        //    //        CurrentPath.Weapon.Found = true;
        //    //        Console.WriteLine($"You found a {CurrentPath.Weapon.Name}. What would you like to do?");
        //    //        Utilities.LoadMenu(this, Utilities, "PickItUp,KeepOnMoving,GoBack");
        //    //    }
        //    //}

        //    ////check for the end of the current patch
        //    //if(Character.CurrentLocation == CurrentPath.Length)
        //    //{
        //    //    Console.WriteLine("You made it to the end of the path!");
        //    //}
          
        //}
    }
}
