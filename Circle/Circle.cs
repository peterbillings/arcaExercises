using System;

namespace Circle
{
    class Circle
    {
        public double Radius {get; set;}

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double getDiameter()
        {
            return this.Radius * 2;
        }

        public double getArea()
        {
            return Math.PI * Math.Pow(this.Radius, 2);
        }

    }
}

