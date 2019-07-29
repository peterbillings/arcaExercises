using System;

namespace Dashboard
{
    class Program
    {
        static void Main(string[] args)
        {
            Dashboard dashboard = new Dashboard(65, 1500);
            
            Console.WriteLine(dashboard.getDisplay());

            dashboard.Speed = 75;

            dashboard.RPM  = 2000;

            Console.WriteLine(dashboard.getDisplay());
        }
    }
}
