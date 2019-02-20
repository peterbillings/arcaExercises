using System;

namespace TicTacToe
{
    class Player
    {
        public Player()
        {

        }

        public Position ChooseASquareOnTheBoard(string positionChoice)
        { 
            return (Position)Convert.ToInt32(positionChoice);
        }
    }
}