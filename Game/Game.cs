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
            Character.Move(CurrentPath);

            Console.WriteLine("You are now playing the game....add more game elements here...");

            Utilities.LoadMenu(this, Utilities, "SaveGameData,ViewCharacterStats,Battle,Exit");
        }
    }
}
