using System;

namespace TypeConversionExperiment
{
    class Program
    {
        static void Main(string[] args)
        {

        Console.WriteLine(Convert.ToBoolean(1)); //true
        Console.WriteLine(Convert.ToBoolean(0)); //true
        Console.WriteLine(Convert.ToBoolean(-1)); //false
        Console.WriteLine(Convert.ToBoolean(1.0)); //true
        Console.WriteLine(Convert.ToBoolean(0.0)); //false
        Console.WriteLine(Convert.ToBoolean(-1.0)); //true
        Console.WriteLine(Convert.ToBoolean("True")); //true
        Console.WriteLine(Convert.ToBoolean("False")); //false
        // throws exception ?Console.WriteLine(Convert.ToBoolean(""));
        // throws exception ?Console.WriteLine(Convert.ToBoolean("Whatever"));            
        }
    }
}
