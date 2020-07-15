using Game.Characters;
using System;

namespace Game
{
    public class Utilities
    {
        public string Selection;

        public void DisplayHeader()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("GAME TITLE");
        }

        public void DisplayMenu()
        {
            // see if I can add logic to this so that once an option is selected, it will show that it has already been selected and will not be available again
            Console.WriteLine("\r\nPlease select an option below... ");
            Console.WriteLine("1. Start New Game");
            Console.WriteLine("2. Load Saved Game");
            Console.WriteLine("3. Create Character");
            Console.WriteLine("4. Save Game Data");          
            Console.WriteLine("5. View Character Stats");
            Console.WriteLine("6. Battle");
            Console.WriteLine("7. Exit");
            Selection = Console.ReadLine();
        }

        public string GetPath()
        {
            string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            return path.Substring(6).Replace("bin\\Debug", "");
        }


        public Character CreateNewCharacter()
        {
            Console.WriteLine("What kind of character would you like to create?");
            Console.WriteLine("1. FastRunner");
            Console.WriteLine("2. Gunner");
            Console.WriteLine("3. HeavyHitter");
            string choice = Console.ReadLine();
            Character character = new Character();
          
            switch (choice)
            {
                case "1":
                    character = new FastRunner();
                    break;
                case "2":
                    character = new Gunner();
                    break;
                case "3":
                    character = new HeavyHitter();
                    break;
            }

            return character;
        } 
    }
}