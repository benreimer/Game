using System;

namespace Game.Armor
{
    [Serializable()]
    public class Armor
    {
        public string Name;
        public int DefensePoints;
        public string Class;  //this will be the character class to which this piece of armor is available
    }
}
