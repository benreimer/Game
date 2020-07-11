using System;

namespace Game
{
    class Program
    {
        public bool ExitLoop;
        public string Path;

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
       

            utilities.DisplayHeader();

            while (!ExitLoop)
            {
                utilities.DisplayMenu();

                switch (utilities.Selection)
                {
                    case "1":
                        Console.WriteLine("Start New Game");
                        break;
                    case "2":
                        Console.WriteLine("Load Saved Game");
                        break;
                    case "3":
                        Console.WriteLine("Create Character");
                        character.CharacterType = utilities.CreateNewCharacter();
                        character.AssignCharacterAttributes();
                        break;
                    case "4":
                        Console.WriteLine("Save Game Data");
                        utilities.SaveGame();
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
