using System;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace Game
{
    public class Program
    {
       public Utilities Utilities = new Utilities();
       public Game CurrentGame = new Game();

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
            Utilities.DisplayHeader();
            Utilities.LoadMainMenu(CurrentGame, Utilities);
            
            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
            Environment.Exit(0);
        }
    }
}