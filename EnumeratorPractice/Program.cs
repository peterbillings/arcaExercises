using System;

namespace EnumeratorPractice
{

    public enum MonthsOfYear { January = 1, February = 2, March = 3, April = 4, May = 5, June = 6, July = 7,
                               August = 8, September = 9, October = 10, November = 11, December = 12}
                               
    class Program
    {
        static void Main(string[] args)
        {
            
            int monthNumber = GetMonthFromUser();
            string monthMessage = GetMonthMessage(monthNumber);
            PrintMonthMessage(monthMessage);
             
        }

        public static int GetMonthFromUser()
        {
            Console.WriteLine("Please enter a number between 1 and 12, corresponding to the desired month.");

            string userInput = Console.ReadLine();

            while(!IsInputTypeAndRangeCorrect(userInput))
            {
                Console.WriteLine("Invalid input, please enter a number 1-12.");

                userInput = Console.ReadLine();
            }
            
            int monthNumber = Convert.ToInt32(userInput);

            return monthNumber;
        }

        public static Boolean IsInputTypeAndRangeCorrect(string userInput)
        {
            if (int.TryParse(userInput, out int result))
            {
                if (result >= 1 && result <= 12 )
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public static string GetMonthMessage(int monthNumber)
        {
            MonthsOfYear month = (MonthsOfYear)monthNumber;

            string season = GetSeasonFromMonth(monthNumber);

            return $"The month of {month} is in {season}";
        }

        public static string GetSeasonFromMonth(int monthNumber)
        {
            string month = "";

            switch (monthNumber)
            {
                case 3:
                case 4:
                case 5:
                    month = "Spring";
                    break;
                case 6:
                case 7:
                case 8:
                    month = "Summer";
                    break;
                case 9:
                case 10:
                case 11:
                    month = "Fall";
                    break;
                default:
                    month = "Winter";
                    break;
            }
            return month;
        }

        public static void PrintMonthMessage(string message)
        {
            Console.WriteLine(message);
        }


    }
}
