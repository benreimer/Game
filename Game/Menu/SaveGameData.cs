using Newtonsoft.Json;
using System;
using System.IO;

namespace Game.Menu
{
    class SaveGameData : IMenu
    {
        public string Description => "Save Game Data";
        public void Execute(Game game, Utilities utilities) 
        {
            Console.WriteLine("Save Game Data");
            string output = JsonConvert.SerializeObject(game);
            string outputFile = $@"{utilities.GetPath()}\SavedGames\SavedGameData.json";
            File.WriteAllText(outputFile, output);
            Console.WriteLine("Game has been saved");
        }
    }
}
