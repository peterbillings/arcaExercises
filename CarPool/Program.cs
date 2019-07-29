using System;

namespace CarPool
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(4);

            Console.WriteLine(car.GetPassengerCount());

            car.SetPassengerCount(6);

            Console.WriteLine(car.GetPassengerCount());

            car.SetPassengerCount(-5);

            Console.WriteLine(car.GetPassengerCount());
        }
    }
}
