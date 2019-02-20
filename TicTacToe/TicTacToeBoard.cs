using System;

namespace TicTacToe
{
    class TicTacToeBoard
    {
        private PositionState[,] board;


        public TicTacToeBoard()
        {
            board = new PositionState[3,3];
        }

        public PositionState GetPositionState(Position position)
        {
            int row = 0;
            int column = 0;

            for (int i = 1; i <= 9; i++)
            {
                if (i != 1 && i%3 == 1)
                    row++;

                if ( !(i%3 == 1))
                    column++;

                else
                    column = 0;
                
                if ((int)position == i)
                    break;   
            }

            return board[row,column];
        }

        public void SetPositionState(Position position, PositionState positionState)
        {
            int row = 0;
            int column = 0;

            for (int i = 1; i <= 9; i++)
            {
                if (i != 1 && i%3 == 1)
                    row++;

                if ( !(i%3 == 1))
                    column++;
                    
                else
                    column = 0;
                
                if ((int)position == i)
                    break;   
            }

            board[row, column] = positionState;

        }

        // public void BoardWipe(TicTacToeBoard gameBoard)
        // {
        //     gameBoard.SetPositionState(Position.bottomLeft, PositionState._);
        //     gameBoard.SetPositionState(Position.bottomMid, PositionState._);
        //     gameBoard.SetPositionState(Position.bottomRight, PositionState._);
        //     gameBoard.SetPositionState(Position.midLeft, PositionState._);
        //     gameBoard.SetPositionState(Position.midMid, PositionState._);
        //     gameBoard.SetPositionState(Position.midRight, PositionState._);
        //     gameBoard.SetPositionState(Position.topLeft, PositionState._);
        //     gameBoard.SetPositionState(Position.topMid, PositionState._);
        //     gameBoard.SetPositionState(Position.topRight, PositionState._);
        // }

    }
}