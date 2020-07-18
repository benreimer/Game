using Newtonsoft.Json;
using System;
using System.IO;

namespace Game.Menu
{
    class LoadSavedGame : IMenu
    {
        
        public string Description => "Load Saved Game";
        public void Execute(Game game, Utilities utilities)
        {
            Console.WriteLine("Load Saved Game menu item");

           
            
            var fileName = $@"{utilities.GetPath()}\SavedGames\SavedGameData.json";
            using (StreamReader reader = new StreamReader(fileName))
            {
                string json = reader.ReadToEnd();
                game = JsonConvert.DeserializeObject<Game>(json);
            }
            game.Play();
        }
    }
}