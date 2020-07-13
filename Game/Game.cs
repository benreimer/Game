using System;
using System.IO;
using System.Runtime.Remoting.Activation;
using System.Xml.Serialization;
using Game.Characters;

namespace Game
{
    [Serializable()]
    public class Game
    {
        public string Name;
        public Character Character;
        public Base Base;
        public Map Map;
        public Level CurrentLevel;
        public Shop Shop;

        [XmlIgnore()]
        public Utilities Utilities = new Utilities();

       

        public void StartNewGame()
        {
            Name = "NEW GAME";
            Console.WriteLine("Starting a new game....");
            Console.WriteLine("");
            Character = Utilities.CreateNewCharacter();
            Base = new Base();
            Map = new Map();
            CurrentLevel = new Level {LevelNumber = 1};
            Shop = new Shop();
            //  return game;
        }

      //  public static Game LoadSavedGame(string filePath)
      //  {
           // return File.ReadAllText(filePath).XmlDeserialize<Game>();
     //   }


        public void SaveGame()
        {
           // string xmlString = game.XmlSerialize();
            //remove this string from the assessmentDefinition xml: <StartDate>0001-01-01T00:00:00</StartDate><EndDate>0001-01-01T00:00:00</EndDate>
           // File.WriteAllText(outputXmlFile, utilities.PrettyXml(xmlString.Remove(xmlString.IndexOf("<StartDate>", StringComparison.Ordinal), 80)));

            Console.WriteLine("Game has been saved");

        }

      
    }
}
