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
        }
    }
}
