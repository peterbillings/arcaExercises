using System;

namespace FibonacciRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter how manys numbers of the Fibonacci sequence you wish to see: ");

            int fibonacciNumber = Convert.ToInt32(Console.ReadLine());

            while (fibonacciNumber <= 0)
            {
                Console.Write("The number you entered is out of range, please enter a number greater than zero: ");

                fibonacciNumber = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 1; i <= fibonacciNumber; i++)

            {
                Console.Write(Fibonacci(i) + " ");
            }
        }

        public static int Fibonacci(int sequenceNumber)
        {
            if(sequenceNumber == 1 || sequenceNumber == 2)
            {
                return 1;
            }

          return Fibonacci(sequenceNumber - 2) + Fibonacci(sequenceNumber - 1);
        }
    }
}
