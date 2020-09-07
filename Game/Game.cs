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


            QuestPath path = new QuestPath();
            
            string output = JsonConvert.SerializeObject(path);
            string outputFile = $@"{Utilities.GetPath()}\PathData.json";
            File.WriteAllText(outputFile, output);


            var fileName = $@"{Utilities.GetPath()}\PathData.json";
            using (StreamReader reader = new StreamReader(fileName))
            {
                string json = reader.ReadToEnd();
                CurrentPath = JsonConvert.DeserializeObject<QuestPath>(json);
            }
            
            Character = Utilities.CreateNewCharacter();
            
            CurrentLevel = new Level {LevelNumber = 1};
            
            Shop = new Shop();
        }

        public void Play()
        {
            Console.WriteLine("You are now playing the game....add more game elements here...");


            Character.CurrentLocation.DisplayMenu(this, Utilities);

            Utilities.LoadMenu(this, Utilities, "SaveGameData,ViewCharacterStats,Battle,Exit");
        }

    }
}
