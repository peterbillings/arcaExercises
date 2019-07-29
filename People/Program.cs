using System;

namespace People
{
    class Program
    {
        static void Main(string[] args)
        {
            Person me = new Person("Peter", "Billings");

            Console.WriteLine(me.GetFullName());
        }
    }
}
