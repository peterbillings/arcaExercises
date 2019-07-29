using System;

namespace FootballScore
{
    class Program
    {
        static void Main(string[] args)
        {
            Score score = new Score();

            score.completedFieldGoal();

            Console.WriteLine(score.Points);

            score.completedFieldGoal();

            Console.WriteLine(score.Points);

            score.completedTouchdown();

            Console.WriteLine(score.Points);
        }
    }
}
