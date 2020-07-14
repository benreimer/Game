using System;
using System.IO;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Game
{
    class Program
    {
        public bool ExitLoop;
        public string Path;

        [STAThread]
        public static void Main()
        {
            Program p = new Program();
            p.Run();
        }

        private void Run()
        {
            Utilities utilities = new Utilities();
            Path = utilities.GetPath();
            Game game = new Game();
       
            utilities.DisplayHeader();

            while (!ExitLoop)
            {
                utilities.DisplayMenu();

                switch (utilities.Selection)
                {
                    case "1":
                        Console.WriteLine("Start New Game");
                        game.StartNewGame();
                        break;
                    case "2":
                        Console.WriteLine("Load Saved Game");
                        //find absolute path - put this in utilities
                        //https://stackoverflow.com/questions/15653921/get-current-folder-path/23513793#23513793
                        
                        var fileName = $@"{Path}\SavedGames\SavedGameData.json";
                        using (StreamReader reader = new StreamReader(fileName))
                        {
                            string json = reader.ReadToEnd();
                            game = JsonConvert.DeserializeObject<Game>(json);
                        }
                        break;
                    case "3":
                        Console.WriteLine("Create Character");
                        break;
                    case "4":
                        Console.WriteLine("Save Game Data");
                        string output = JsonConvert.SerializeObject(game);
                        string outputFile = $@"{Path}\SavedGames\SavedGameData.json";
                        File.WriteAllText(outputFile, output);
                        Console.WriteLine("Game has been saved");
                        break;
                    case "5":
                        Console.WriteLine("View Character Stats");
                        game.Character.ViewStats();
                        break;
                    case "6":
                        Console.WriteLine("Fight a Battle with your character");
                        Battle battle = new Battle();
                        battle.Fight(game.Character);
                        break;
                    case "7":
                        Environment.Exit(1);
                        break;
                    default:
                        string errorMsg = "You have made an invalid selection.....";
                        Console.WriteLine(errorMsg);
                        Console.ReadLine();
                        Environment.Exit(1);
                        break;
                }
            }

        }
    }
}
