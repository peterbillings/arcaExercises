using System;

namespace Triangle
{
    class Triangle
    {
        public int SideA {get;}
        public int SideB {get;}
        public int SideC {get;}

        public double[] Angles {get;}
        
        public Triangle(int a, int b, int c)
        {
            this.SideA = a;
            this.SideB = b;
            this.SideC = c;
            this.Angles = CalculateAngles();
        }

        public bool isValid()
        {
            int a = this.SideA;
            int b = this.SideB;
            int c = this.SideC;

            return a + b > c && a + c > b && c + b > a;
        }

        public int getPerimeter()
        {
            return this.SideA + this.SideB + this.SideC;
        }

        public bool isEquilateral()
        {
            return this.SideA == this.SideB && this.SideA == this.SideC;
        }

        public bool isIsoceles()
        {
            return this.SideA == this.SideB ||
                   this.SideA == this.SideC ||
                   this.SideB == this.SideC;
        }

        public bool isScalene()
        {
            return this.SideA != this.SideB && this.SideA != this.SideC && this.SideB != this.SideC;
        }


        public bool isRightAngle()
        {
            return this.Angles[0] == 90 || this.Angles[1] == 90 || this.Angles[2] == 90;

            // double aSquared = Math.Pow(this.SideA, 2);
            // double bSquared = Math.Pow(this.SideB, 2);
            // double cSquared = Math.Pow(this.SideC, 2);

            // return aSquared + bSquared == cSquared ||
            //        aSquared + cSquared == bSquared ||
            //        bSquared + cSquared == aSquared;
        }

        public bool isAcute()
        {
            return this.Angles[0] < 90 && this.Angles[1] < 90 && this.Angles[2] < 90;
        }

        public bool isObtuse()
        {
            return this.Angles[0] > 90 || this.Angles[1] > 90 || this.Angles[2] > 90;
        }

        private double[] CalculateAngles()
        {
            double[] angles = new double[3];

            double sideA = this.SideA;
            double sideB = this.SideB;
            double sideC = this.SideC;

            double convertRadians = 180 / Math.PI;

            angles[0] = convertRadians * (Math.Acos((Math.Pow(sideA, 2) + Math.Pow(sideB, 2) - Math.Pow(sideC, 2)) /
                        (2 * sideA * sideB)));

            angles[1] = convertRadians * (Math.Acos((Math.Pow(sideB, 2) + Math.Pow(sideC, 2) - Math.Pow(sideA, 2)) /
                        (2 * sideB * sideC)));

            angles[2] = convertRadians * (Math.Acos((Math.Pow(sideC, 2) + Math.Pow(sideA, 2) - Math.Pow(sideB, 2)) /
                        (2 * sideC * sideA)));

            // Console.WriteLine($"The angles are: {angles[0]}, {angles[1]}, {angles[2]}");

            return angles;

            // cos(C) =  (a^2 + b^2 − c^2) / 2ab (Law of Cosines)

            // cos(A) =  (b^2 + c^2 − a^2) / 2bc

            // cos(B) =  (c^2 + a^2 − b^2) / 2ca
        }
    }
}