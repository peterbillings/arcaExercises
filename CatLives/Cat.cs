using System;

namespace CatLives
{
    class Cat
    {
        public int Lives {get; private set;}

        public Cat()
        {
            this.Lives = 9;
        }

        public void Kill()
        {
            if(this.Lives > 0)
            {
                this.Lives--;
            }
            else
            {
                Console.WriteLine("The cat is now dead... or undead depending on your skill in necromancy");
            }
        }
    }
}