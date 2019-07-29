using System;

namespace CarPool
{
    class Car
    {
        public int PassengerCount {get; private set;}

        public Car(int passengerCount)
        {
            this.PassengerCount = passengerCount;
        }

        public int GetPassengerCount()
        {
            return this.PassengerCount;
        }

        public void SetPassengerCount(int passengerCount)
        {
            if (passengerCount >= 0)
            {
                this.PassengerCount = passengerCount;
            }
            else
            {
                Console.WriteLine("There is no such thing as negative people!");
            }
            
        }
    }
}