using Game.Characters;
using System;
using Game.Menu;
using System.Linq;

namespace Game
{
    public class Utilities
    {
        public string Selection;


        public void LoadMenu(string menuSelections)
        {
            var count = menuSelections.Split((',')).Length;
            IMenu[] commands = new IMenu[0];

            foreach (var menuItem in menuSelections.Split(','))
            {
                try
                {
                    var type = Type.GetType("Game.Menu." + menuItem);
                    var myObject = (IMenu)Activator.CreateInstance(type);

                    Array.Resize(ref commands, commands.Length + 1);
                    commands[commands.Length - 1] = myObject;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Invalid Menu Item passed to menu function - no method exists for this MenuSelection: {menuItem}");
                    Console.WriteLine($"Press any key to exit...");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
            }

            Console.WriteLine("What do you want to do?");

            // This loop creates a list of commands:
            for (int i = 0; i < commands.Length; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, commands[i].Description);
            }

            // Read until the input is valid.
            var userChoice = string.Empty;
            var commandIndex = -1;
            do
            {
                userChoice = Console.ReadLine();
            }
            while (!int.TryParse(userChoice, out commandIndex) || commandIndex > commands.Length);

            // Execute the command.
            commands[commandIndex - 1].Execute();
        }

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