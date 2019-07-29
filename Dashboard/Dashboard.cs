using System;

namespace Dashboard
{
    class Dashboard
    {
        public int Speed {get; set;}
        public int RPM {get; set;}

        public Dashboard(int speed, int rpm)
        {
            this.Speed = speed;

            this.RPM = rpm;
        }

        public string getDisplay()
        {
            return $"Speed: {this.Speed}   RPM: {this.RPM}";
        }
    }
}