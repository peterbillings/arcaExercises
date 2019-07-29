using System;

namespace DnDCharacterCreator
{
    class BaseCharacter
    {
        protected int strength;
        protected int dexterity;
        protected int constitution;
        protected int intelligence;
        protected int wisdom;
        protected int charisma;
        protected int passiveWisdom;
        
        private int[] GenerateAbilityScores()
        {
            int[] arrayOfAbilityScores = new int[6];
            int strength, dexterity, constitution, intelligence, wisdom, charisma;
            //generate 6 random numbers that are between 8-18 that all sum to 78
            //assign them as elements to the return array


            return arrayOfAbilityScores;
        }
    }
}