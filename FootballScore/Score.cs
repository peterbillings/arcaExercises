using System;

namespace FootballScore
{
    class Score
    {
        public int Points {get; set;}

        public Score()
        {
            this.Points = 0;
        }

        public void completedFieldGoal()
        {
            this.Points += 3;
        }

        public void completedTouchdown()
        {
            this.Points += 6;
        }
    }
}