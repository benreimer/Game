using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Character
    {
        public string CharacterClassName;
        public int Health;
        public int HitPoints;
        public int MaxSpeed;
        public Weapon Weapons;
        public Armor Armor;     


        public void ViewStats()
        {

            Console.WriteLine($"Character Class Name: {CharacterClassName}");
            Console.WriteLine($"Health: {Health}");
            Console.WriteLine($"Hit Points: {HitPoints}");
            Console.WriteLine($"Max Speed: {MaxSpeed}");

        }



    }
}
