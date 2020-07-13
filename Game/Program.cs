﻿using System;
using System.IO;
using Game.Characters;

namespace Game
{
    class Program
    {
        public bool ExitLoop;
        public string Path;
       // public Game Game;

        [STAThread]
        static void Main()
        {
            Program p = new Program();
            p.Run();
        }

        private void Run()
        {
            Utilities utilities = new Utilities();
            Character character = new Character();
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
                        break;
                    case "3":
                        Console.WriteLine("Create Character");
                        character = utilities.CreateNewCharacter();                     
                        break;
                    case "4":
                        Console.WriteLine("Save Game Data");
                        string xmlString = game.XmlSerialize();
                        string outputXmlFile = $@"C:\GIT\Game\SavedGameData.xml";
                        File.WriteAllText(outputXmlFile, utilities.PrettyXml(xmlString));

                        Console.WriteLine("Game has been saved");
                       // game.SaveGame();
                        break;
                    case "5":
                        Console.WriteLine("View Character Stats");
                        character.ViewStats();
                        break;
                    case "6":
                        Console.WriteLine("Fight a Battle with your character");
                        Battle battle = new Battle();
                        battle.Fight(character);
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
