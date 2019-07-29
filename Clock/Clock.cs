using System;

namespace Clock
{
    class Clock
    {
        public int Hour {get; private set;}

        public int Minute {get; private set;}

        public int[] AlarmTime {get; private set;}

        public bool AlarmOn {get; private set;}

        public TimeZone TimeZone {get; private set;}

        public Clock(int hour, int minute)
        {
            this.Hour = hour;
            this.Minute = minute;
            this.AlarmTime = new int[2] {12, 0};
            this.AlarmOn = false;
            this.TimeZone = TimeZone.GMT;
        }

        public Clock(int hour, int minute, bool isPM)
        {
            if(isPM)
            {
                hour += 12;
            }

            if(!isPM && hour == 12)
            {
                hour = 0;
            }

            this.Hour = hour;
            this.Minute = minute;
            this.AlarmTime = new int[2] {12, 0};
            this.AlarmOn = false;
            this.TimeZone = TimeZone.GMT;
        }

        public string GetMilitaryTime()
        {
            if (this.AlarmOn)
            {
                this.TurnAlarmOff();

                this.AdjustForTimeZone();

                this.TurnAlarmOn();
            }
            else
            {
               this.AdjustForTimeZone();
            }

            string minute = "" + this.Minute;

            string hour = "" + this.Hour;

            if (minute.Length < 2)
            {
                minute = "0" + minute;
            }

            this.ResetToGMT();

            return $"{hour}:{minute}";
        }

        public string GetTime()
        {
            
            if (this.AlarmOn)
            {
                this.TurnAlarmOff();

                this.AdjustForTimeZone();

                this.TurnAlarmOn();
            }
            else
            {
                this.AdjustForTimeZone();
            }

            string minute = "" + this.Minute;

            string hour;

            string amPM;

            if (this.Hour > 11)
            {
                amPM = "PM";

                hour = "" + this.Hour % 12;
            }
            else
            {
                amPM = "AM";

                hour = "" + this.Hour;
            }

            if (minute.Length < 2)
            {
                minute = "0" + minute;
            }

            this.ResetToGMT();

            return $"{hour}:{minute} {amPM}";
        }

        public void IncrementHour()
        {
            if(this.Hour == 23)
            {
                this.Hour = 0;
            }
            else
            {
                this.Hour++;
            }

            this.Buzz();
        }

        public void DecrementHour()
        {
            if(this.Hour == 0)
            {
                this.Hour = 23;
            }
            else
            {
                this.Hour--;
            }

            this.Buzz();
        }

        public void IncrementMinute()
        {
            if(this.Minute == 59)
            {
                this.Minute = 0;
                
                this.IncrementHour();
            }
            else
            {
                this.Minute++;
            }

            this.Buzz();
        }

        public void DecrementMinute()
        {
            if(this.Minute == 0)
            {
                this.Minute = 59;

                this.DecrementHour();
            }
            else
            {
                this.Minute--;
            }

            this.Buzz();
        }

        public void SetAlarmTime(int hour, int minute)
        {
            this.AlarmTime[0] = hour;
            this.AlarmTime[1] = minute;
        }

        private void Buzz()
        {
            if(this.AlarmOn && this.Hour == this.AlarmTime[0] && this.Minute == this.AlarmTime[1])
            {
                Console.WriteLine($"BUZZ! Wake up! It's {this.GetMilitaryTime()}!");
            }  
        }

        public void TurnAlarmOn()
        {
            this.AlarmOn = true;
        }

        public void TurnAlarmOff()
        {
            this.AlarmOn = false;
        }

        public int GetMinutesApart(Clock clock)
        {
            int thisTotalMinutes = (this.Hour * 60) + this.Minute;

            int clockTotalMinutes = (clock.Hour * 60) + clock.Minute;

            return thisTotalMinutes - clockTotalMinutes;
        }

        public void SetTimeZone(int timezone)
        {
            if (timezone < 0 || timezone > 4)
            {
                return;
            }
            else
            {
                this.TimeZone = (TimeZone)timezone;
            }
        }

        private void AdjustForTimeZone()
        {
           for (int i = 0; i < (int)this.TimeZone; i++)
                {
                    this.IncrementHour();
                } 
        }

        private void ResetToGMT()
        {
           for (int i = 0; i < (int)this.TimeZone; i++)
                {
                    this.DecrementHour();
                } 
        }

    }
}