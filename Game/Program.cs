using System;
using System.IO;
using System.Runtime.InteropServices;
using Newtonsoft.Json;
using System.Diagnostics;
using Game.Menu;

namespace Game
{
    public class Program
    {
        public bool ExitLoop;
        public string Path;
        public Utilities Utilities = new Utilities();

        //disable console app close menu
        //code was found here: https://social.msdn.microsoft.com/Forums/vstudio/en-US/545f1768-8038-4f7a-9177-060913d6872f/disable-close-button-in-console-application-in-c?forum=csharpgeneral
        [DllImport("user32.dll")]
        static extern bool EnableMenuItem(IntPtr hMenu, uint uIDEnableItem, uint uEnable);

        [DllImport("user32.dll")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
       
        [DllImport("user32.dll")]
        static extern IntPtr RemoveMenu(IntPtr hMenu, uint nPosition, uint wFlags);
        internal const uint SC_CLOSE = 0xF060;
        internal const uint MF_GRAYED = 0x00000001;
        internal const uint MF_BYCOMMAND = 0x00000000;
        //end disable console app close menu
           

        [STAThread]
        public static void Main(string[] args)
        {

            IntPtr hMenu = Process.GetCurrentProcess().MainWindowHandle;
            IntPtr hSystemMenu = GetSystemMenu(hMenu, false);
            EnableMenuItem(hSystemMenu, SC_CLOSE, MF_GRAYED);
            RemoveMenu(hSystemMenu, SC_CLOSE, MF_BYCOMMAND);           

            Program p = new Program();
            p.Run();
        }

        private void Run()
        {
           // Utilities utilities = new Utilities();
            Path = Utilities.GetPath();
            Game game = new Game();

            //utilities.LoadMenu("StartNewGame,LoadSavedGame");
            IMenu[] commands = new IMenu[]
           {
                new StartNewGame(),
                new LoadSavedGame()
           };
            Utilities.LoadMenu(commands);

            
            

            Utilities.DisplayHeader();

            while (!ExitLoop)
            {
                Utilities.DisplayMenu();

                switch (Utilities.Selection)
                {
                    case "1":
                        Console.WriteLine("Start New Game");
                        game.StartNewGame();
                        game.Play();
                        break;
                    case "2":
                        Console.WriteLine("Load Saved Game");
                        var fileName = $@"{Path}\SavedGames\SavedGameData.json";
                        using (StreamReader reader = new StreamReader(fileName))
                        {
                            string json = reader.ReadToEnd();
                            game = JsonConvert.DeserializeObject<Game>(json);
                        }
                        game.Play();
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