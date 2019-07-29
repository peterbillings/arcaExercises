using System;

namespace RideAdmittance
{
    class Program
    {
        static void Main(string[] args)
        {
            // 36" or less == red wristband
            // more than 36" and less than 54" == yellow wristband
            // 54" to 80" == green wristband
            // greater than 80" == no wristband, too tall

            Console.Write("Please enter your height in inches: ");

            int height = Convert.ToInt32(Console.ReadLine());

            if (height <= 36)
            {
                Console.WriteLine("Red Wristband");
            }

            else if (height > 36 && height < 54)
            {
                Console.WriteLine("Yellow Wristband");
            }

            else if (height >= 54 && height <= 80)
            {
                Console.WriteLine("Green Wristband");
            }
            
            else
            {
                Console.WriteLine("No wristband, you're too tall to ride!");
            }
        }
    }
}
