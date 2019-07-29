using System;

namespace CodeTestSandbox
{
    abstract class Polygon
    {
        protected int Sides {get; set;}

        public Polygon(int sides)
        {
            this.Sides = sides;
        }

        public abstract void InheritanceAchieved();
    }
}