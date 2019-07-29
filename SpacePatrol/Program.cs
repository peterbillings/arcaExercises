using System;

namespace SpacePatrol
{
    class Program
    {
        static void Main(string[] args)
        {
            Spaceship spaceship = new Spaceship("The Chungus");

            spaceship.AddPassenger();

            spaceship.AddPassenger();

            Console.WriteLine(spaceship.PassengerCount);

            spaceship.RemovePassenger();

            Console.WriteLine(spaceship.PassengerCount);

            spaceship.RemoveAllPassengers();

            Console.WriteLine(spaceship.PassengerCount);

            spaceship.RemovePassenger();

            Console.WriteLine(spaceship.GetShipDescription());
        }
    }
}
