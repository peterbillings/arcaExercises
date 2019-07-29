using System;

namespace HomeBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            House house = new House(5);

            Console.WriteLine(house.GetRoomCount());

            Console.WriteLine(house.RoomCount);

            // house.RoomCount = 6;

        }
    }
}
