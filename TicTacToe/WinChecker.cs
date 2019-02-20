using System;

namespace TicTacToe
{
    class WinChecker
    {
        public WinChecker()
        {

        }

        public bool XWins {get; private set;} = false;
        public bool OWins {get; private set;} = false;
        public bool _Wins {get; private set;} = false;

        public void CheckForWinner(TicTacToeBoard gameBoard)
        {
            int[] winStates = new int[8];

            winStates[0] = (int)gameBoard.GetPositionState(Position.bottomLeft) +
                           (int)gameBoard.GetPositionState(Position.midMid) +
                           (int)gameBoard.GetPositionState(Position.topRight);

            winStates[1] = (int)gameBoard.GetPositionState(Position.bottomLeft) +
                           (int)gameBoard.GetPositionState(Position.bottomMid) +
                           (int)gameBoard.GetPositionState(Position.bottomRight);

            winStates[2] = (int)gameBoard.GetPositionState(Position.midLeft) +
                           (int)gameBoard.GetPositionState(Position.midMid) +
                           (int)gameBoard.GetPositionState(Position.midRight);

            winStates[3] = (int)gameBoard.GetPositionState(Position.topLeft) +
                           (int)gameBoard.GetPositionState(Position.topMid) +
                           (int)gameBoard.GetPositionState(Position.topRight);

            winStates[4] = (int)gameBoard.GetPositionState(Position.topLeft) +
                           (int)gameBoard.GetPositionState(Position.midMid) +
                           (int)gameBoard.GetPositionState(Position.bottomRight);

            winStates[5] = (int)gameBoard.GetPositionState(Position.bottomLeft) +
                           (int)gameBoard.GetPositionState(Position.midLeft) +
                           (int)gameBoard.GetPositionState(Position.topLeft);

            winStates[6] = (int)gameBoard.GetPositionState(Position.bottomMid) +
                           (int)gameBoard.GetPositionState(Position.midMid) +
                           (int)gameBoard.GetPositionState(Position.topMid);

            winStates[7] = (int)gameBoard.GetPositionState(Position.bottomRight) +
                           (int)gameBoard.GetPositionState(Position.midRight) +
                           (int)gameBoard.GetPositionState(Position.topRight);

            foreach (int winCondition in winStates)
            {
                if (winCondition == 3)
                {
                    XWins = true;
                    break;
                }

                if (winCondition == 12)
                {
                    OWins = true;
                    break;
                }
            }            
        }

        public void CheckForDraw(int turnCount)
        {
            if (turnCount == 9 && XWins == false && OWins == false)
                _Wins = true;
        }
    }
}