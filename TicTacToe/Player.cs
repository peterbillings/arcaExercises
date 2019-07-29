using System;

namespace TicTacToe
{
    class Player
    {
        private InputChecker inputChecker;

        public Player()
        {
            inputChecker = new InputChecker();
        }

        public Position ChooseASquareOnTheBoard(string positionChoice)
        {         
            while (! inputChecker.IsInputTypeAndRangeCorrect(positionChoice))
            {
                Console.WriteLine("Invalid input! Try again! (1-9)");

                positionChoice = Console.ReadLine();
            }

            return (Position)Convert.ToInt32(positionChoice);
        }
    }
}