using System;
using System.Xml.Serialization;
using Game.Characters;

namespace Game
{
    [Serializable()]
    public class Game
    {
        public string Name;
        public Character Character;

        [XmlIgnore()]
        public Utilities Utilities = new Utilities();

       

        public void StartNewGame()
        {
            Name = "NEW GAME";
            Console.WriteLine("Starting a new game....");
            Console.WriteLine("");
            Character = Utilities.CreateNewCharacter();
          //  return game;
        }


        public void SaveGame()
        {
           // string xmlString = game.XmlSerialize();
            //remove this string from the assessmentDefinition xml: <StartDate>0001-01-01T00:00:00</StartDate><EndDate>0001-01-01T00:00:00</EndDate>
           // File.WriteAllText(outputXmlFile, utilities.PrettyXml(xmlString.Remove(xmlString.IndexOf("<StartDate>", StringComparison.Ordinal), 80)));

            Console.WriteLine("Game has been saved");

        }

      
    }
}
