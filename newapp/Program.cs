using System;

namespace newapp
{
    class Program
    {
        static void Main(string[] args)
        {
            // int x = 42;

            // Console.WriteLine(int.TryParse(Console.ReadLine(), out int result));
            // Console.WriteLine(result);

            // Console.WriteLine(IsInputTypeAndRangeCorrect("32"));
            // Console.WriteLine(IsInputTypeAndRangeCorrect("-12"));
            // Console.WriteLine(IsInputTypeAndRangeCorrect("ad"));
            Console.WriteLine(IsInputTypeAndRangeCorrect("1"));
            Console.WriteLine(IsInputTypeAndRangeCorrect("2"));
            Console.WriteLine(IsInputTypeAndRangeCorrect("3"));
            Console.WriteLine(IsInputTypeAndRangeCorrect("4"));
            Console.WriteLine(IsInputTypeAndRangeCorrect("5"));
            Console.WriteLine(IsInputTypeAndRangeCorrect("6"));
            Console.WriteLine(IsInputTypeAndRangeCorrect("7"));
            Console.WriteLine(IsInputTypeAndRangeCorrect("8"));
            Console.WriteLine(IsInputTypeAndRangeCorrect("9"));

            

        }

        public static Boolean IsInputTypeAndRangeCorrect(string playerInput)
        {
            if (int.TryParse(playerInput, out int result))
            {
                if (result > 0 && result < 10 )
                    return true;
                else
                    return false;
            }
            else
                return false;
        }
    }
}
