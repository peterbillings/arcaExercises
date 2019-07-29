using System;

namespace Exercise3S2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a long (integral type) number: ");

            long inputNumber = Convert.ToInt64(Console.ReadLine());

            long absValueInputNumber = Math.Abs(inputNumber);

            bool fitsInByte = Byte.MaxValue >= absValueInputNumber;

            bool fitsInSByte = SByte.MaxValue >= absValueInputNumber;

            bool fitsInShort = Int16.MaxValue >= absValueInputNumber;

            bool fitsInUShort = UInt16.MaxValue >= absValueInputNumber;

            bool fitsInInt = Int32.MaxValue >= absValueInputNumber;

            bool fitsInUInt = UInt32.MaxValue >= absValueInputNumber;

            bool fitsInLong = Int64.MaxValue >= absValueInputNumber;

            bool fitsInULong = Int64.MaxValue >= absValueInputNumber;  

            bool fitsInChar = Char.MaxValue >= absValueInputNumber;

            if (inputNumber < 0)
            {
                fitsInByte = false;
                fitsInUShort = false;
                fitsInUInt = false;
                fitsInULong = false;
                fitsInChar = false;
            }

            Console.WriteLine($"Byte:   {fitsInByte}");
            Console.WriteLine($"SByte:  {fitsInSByte}");
            Console.WriteLine($"Short:  {fitsInShort}");
            Console.WriteLine($"UShort: {fitsInUShort}");
            Console.WriteLine($"Int:    {fitsInInt}");
            Console.WriteLine($"UInt:   {fitsInUInt}");
            Console.WriteLine($"Long:   {fitsInLong}");
            Console.WriteLine($"ULong:  {fitsInULong}");
            Console.WriteLine($"Char:   {fitsInChar}");
        }
    }
}
