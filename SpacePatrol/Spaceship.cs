using System;

namespace SpacePatrol
{
    class Spaceship
    {
        public string ShipName {get; private set;}

        public int PassengerCount {get; private set;}

        public Spaceship(string shipName)
        {
            this.ShipName = shipName;

            this.PassengerCount = 0;
        }

        public void AddPassenger()
        {
            this.PassengerCount++;
        }

        public void RemovePassenger()
        {
            if(this.PassengerCount > 0)
            {
                this.PassengerCount--;
            }
            else
            {
                Console.WriteLine("There isn't anyone in the ship!");
            }
            
        }

        public void RemoveAllPassengers()
        {
            this.PassengerCount = 0;
        }

        public string GetShipDescription()
        {
            return $"This ship is named {this.ShipName} and it currently contains {this.PassengerCount} passengers.";
        }
    }
}