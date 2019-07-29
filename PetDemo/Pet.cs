using System;

namespace PetDemo
{
    class Pet
    {
        public string Name {get; private set;}

        private string Definition = "An animal kept for amusement or companionship.";

        public Pet(string name)
        {
            this.Name = name;
        }

        public void PrintName()
        {
            Console.WriteLine(this.Name);
        }

        public void PrintDefinition()
        {
            Console.WriteLine(this.Definition);
        }
    }
}