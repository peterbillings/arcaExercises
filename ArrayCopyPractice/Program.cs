using System;

namespace ArrayCopyPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] initialArray = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            int[] copyArray = new int[initialArray.Length];

            for (int i = 0; i < initialArray.Length; i++)
            {
                copyArray[i] = initialArray[i];

                Console.WriteLine($"Intial value for [{i}]: {initialArray[i]}  Copied value for [{i}]: {copyArray[i]}");
            }
        }
    }
}
