using System;

namespace PetDemo
{
    class PetTester
    {
        static void Main(string[] args)
        {
            Pet firstPet = new Pet("Rover");

            Pet secondPet = new Pet("Fluffy");

            firstPet.PrintName();

            secondPet.PrintName();

            firstPet.PrintDefinition();
        }
    }
}