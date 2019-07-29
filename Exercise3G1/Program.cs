using System;

namespace Exercise3G1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the total number of seconds you wish to convert: ");

            ulong totalSeconds = Convert.ToUInt64(Console.ReadLine());

            ulong convertedHours = totalSeconds / 3600;

            ulong convertedMinutes = (totalSeconds % 3600) / 60;

            ulong remainingSeconds = (totalSeconds % 60);

            Console.WriteLine($"{convertedHours} hours, {convertedMinutes} minutes, and {remainingSeconds} seconds have elapsed."); 
        }
    }
}
