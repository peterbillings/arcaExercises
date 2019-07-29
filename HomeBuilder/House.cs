using System;

namespace HomeBuilder
{
    class House
    {
        public int RoomCount {get; private set;}

        public House(int roomCount)
        {
            this.RoomCount = roomCount;
        }

        public int GetRoomCount()
        {
            return this.RoomCount;
        }
    }

}