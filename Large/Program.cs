using System;

namespace Large
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = GetNumberFromUser();

            string largenessMessage = GetLargenessMessage(number);

            Console.Write(largenessMessage);
        }

        public static string GetLargenessMessage(int numberFromUser)
        {
            if (numberFromUser > 99)
            {
                return "The number is large";
            }
            else
            {
                return "The number is not large";
            }
        }
        

        public static int GetNumberFromUser()
        {
            Console.Write("Please enter an integer number: ");

            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
