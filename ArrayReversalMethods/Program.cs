using System;

namespace ArrayReversalMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the length of the array you want to reverse!");

            int arrayLength = Convert.ToInt32(Console.ReadLine());

            PrintNumbers(ReverseArray(GenerateNumbers(arrayLength)));
        }

        public static int[] GenerateNumbers(int length)
        {
            int[] forwardArray = new int[length];

            int counter = 1;

            for ( int i = 0; i < length; i++)
            {
                forwardArray[i] = counter;
                
                counter++;
            }

            foreach(int number in forwardArray)
            {
                Console.Write(number + " ");   
            }

            Console.WriteLine("\n");
            
            return forwardArray;
        }

        public static int[] ReverseArray(int[] arrayToReverse)
        {
            int[] reverseArray = new int[arrayToReverse.Length];

            int counter = arrayToReverse.Length;

            for (int i = 0; i < reverseArray.Length; i++)
            {
                reverseArray[i] = counter;

                counter--;
            }

            return reverseArray;
        }

        public static void PrintNumbers(int[] arrayToPrint)
        {
            foreach( int number in arrayToPrint)
            {
                Console.Write(number + " ");
            }
        }
    }
}
