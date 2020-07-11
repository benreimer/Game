using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Character
    {
        public string CharacterType;
        public string CharacterClassName;
        public int Health;
        public int HitPoints;
        public int MaxSpeed;
        public Weapon Weapons;
        public Armor Armor;

          

        public void AssignCharacterAttributes()
        {
            switch (CharacterType)
            {
                case "1":
                    CharacterClassName = "FastRunner";
                    Health = 100;
                    HitPoints = 20;
                    MaxSpeed = 100;
                    Weapons = new Weapon();
                    Armor = new Armor();
                    break;
                case "2":
                    CharacterClassName = "Gunner";
                    Health = 100;
                    HitPoints = 45;
                    MaxSpeed = 85;
                    Weapons = new Weapon();
                    Armor = new Armor();
                    break;
                case "3":
                    CharacterClassName = "HeavyHitter";
                    Health = 100;
                    HitPoints = 60;
                    MaxSpeed = 65;
                    Weapons = new Weapon();
                    Armor = new Armor();
                    break;                
            }
        }
    }
}
