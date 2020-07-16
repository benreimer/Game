using System;
using Game.Characters;

namespace Game
{
    public class Battle
    {
        public Battle()
        {   
        }

        public void Hit(Character character, Character opponent)
        {
            opponent.Health -= character.HitPoints;
        }

        public void Fight(Character character)
        {
            Character computerCharacter = new FastRunner();
            while(character.Health > 0 && computerCharacter.Health > 0)
            {
                Hit(character, computerCharacter);
                Hit(computerCharacter, character);                
            }
            DetermineWinner(character, computerCharacter);
        }

        public void DetermineWinner(Character character, Character opponent)
        {
            if(character.Health > 0)
            {
                Console.WriteLine("You have WON this battle!");
            }
            if (opponent.Health > 0)
            {
                Console.WriteLine("You have LOST this battle!");
            }
        }

        public void DefendBase()
        {

        }
    }
}
