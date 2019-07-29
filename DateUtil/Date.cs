using System;

namespace DateUtil
{
    class Date
    {
        public int Day {get; set;}
        public int Month {get; set;}
        public int Year {get; set;}

        public Date(int day, int month, int year)
        {
            this.Day = day;
            this.Month = month;
            this.Year = year;
        }

        public string GetFormattedDate()
        {
            string day = "" + this.Day;

            string month = "" + this.Month;

            string year = "" + this.Year;

            if (day.Length < 2)
            {
                day = "0" + day;
            }

            if (month.Length < 2)
            {
                month = "0" + month;
            }

            return $"{year}-{month}-{day}";
        }
    }
}