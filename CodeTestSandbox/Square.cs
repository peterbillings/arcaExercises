using System;

namespace CodeTestSandbox
{
    sealed class Square : Polygon
    {
        public int Size {get; set;}

        public Square(int size) : base(4)
        {
            this.Size = size;
        }

        public int CalculatePerimeter()
        {
            return this.Size * 4;
        }

        public override void InheritanceAchieved()
        {
            Console.WriteLine("This method was overridden from Polygon by the Square class.");
        }
    }
}