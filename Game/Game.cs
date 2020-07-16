using System;
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

        public void StartNewGame()
        {
            Name = "NEW GAME";
            Console.WriteLine("Starting a new game....");
            Console.WriteLine("");
            Character = Utilities.CreateNewCharacter();
            Base = new Base();
            Console.WriteLine("Would you like to Load A Map or start with the Default Map?");
            Map = new Map();
            Map = Map.LoadDefaultMap();

            CurrentLevel = new Level {LevelNumber = 1};
            
            Shop = new Shop();
        }

        public void Play()
        {
            Console.WriteLine("You are now playing the game....add game elements here...");
            CurrentPath = Map.Paths[0];
            Character.Move(CurrentPath);




        }
    }
}
