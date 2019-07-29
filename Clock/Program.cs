using System;

namespace Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            Clock clock1 = new Clock(9, 03);

            Clock clock2 = new Clock(9, 45);

            Clock clock3 = new Clock(14, 07);

            Clock clock4 = new Clock(14, 30);

            // Clock clock1 = new Clock(9, 03, false);

            // Clock clock2 = new Clock(9, 45, false);

            // Clock clock3 = new Clock(2, 07, true);

            // Clock clock4 = new Clock(2, 30, true);

            // Console.WriteLine(clock1.GetMilitaryTime());

            // Console.WriteLine(clock2.GetMilitaryTime());

            // Console.WriteLine(clock3.GetMilitaryTime());

            // Console.WriteLine(clock4.GetMilitaryTime());

            // Console.WriteLine(clock1.GetTime());

            // Console.WriteLine(clock2.GetTime());

            // Console.WriteLine(clock3.GetTime());

            // Console.WriteLine(clock4.GetTime());

            // clock1.SetAlarmTime(10, 5);

            // clock1.TurnAlarmOn();

            // clock1.IncrementHour();
            // clock1.IncrementMinute();
            // clock1.IncrementMinute();
            // clock1.SetAlarmTime(9, 5);
            // clock1.TurnAlarmOff();
            // clock1.DecrementHour();

            clock1.SetTimeZone(4);

            Console.WriteLine(clock1.GetMilitaryTime());

            Console.WriteLine(clock1.GetTime());

            Console.WriteLine(clock1.GetMinutesApart(clock2) + " minutes");

            Console.WriteLine(clock2.GetMinutesApart(clock1) + " minutes");
        }
    }
}
