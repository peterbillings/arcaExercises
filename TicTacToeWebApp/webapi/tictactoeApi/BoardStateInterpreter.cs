using System;

namespace tictactoeApi
{
    public class BoardStateInterpreter
    {
        public string[] WinStates {get; set;}

        public string CurrentTurn {get; set;}

        public int TurnCount {get; set;}

        public BoardStateInterpreter(TictactoeBoard board)
        {
            UpdateBoardState(board);

            this.WinStates = new string[8]
            {
                board._1 + board._2 + board._3, // bottom row
                board._4 + board._5 + board._6, // middle row
                board._7 + board._8 + board._9, // top row
                board._1 + board._4 + board._7, // left column
                board._2 + board._5 + board._8, // middle column
                board._3 + board._6 + board._9, // right column
                board._1 + board._5 + board._9, // bottom diagonal
                board._7 + board._5 + board._3  // top diagonal
            };
        }

        public void UpdateBoardState(TictactoeBoard board)
        {
            int xCount = 0;
            int oCount = 0;
            int chosenSquare = Convert.ToInt32(board.ChosenSquare);

            string[] currentBoard = new string[9] 
            {
                board._1,
                board._2,
                board._3,
                board._4,
                board._5,
                board._6,
                board._7,
                board._8,
                board._9,
            };

            foreach (string square in currentBoard)
            {
                if (square.Equals("X"))
                {
                    xCount++;
                }
                if (square.Equals("O"))
                {
                    oCount++;
                }
            }

            if(xCount == oCount)
            {
                currentBoard[chosenSquare -1] = "X";
                this.CurrentTurn = "X";
            }
            else
            {
                currentBoard[chosenSquare - 1] = "O";
                this.CurrentTurn = "O";
            }

            this.TurnCount = xCount + oCount + 1;

            board._1 = currentBoard[0];
            board._2 = currentBoard[1];
            board._3 = currentBoard[2];
            board._4 = currentBoard[3];
            board._5 = currentBoard[4];
            board._6 = currentBoard[5];
            board._7 = currentBoard[6];
            board._8 = currentBoard[7];
            board._9 = currentBoard[8];
        }

        public string CheckForWinner()
        {
            foreach (string winState in this.WinStates)
            {
                if (winState.Equals("XXX"))
                {
                    return "X";
                }
                
                if (winState.Equals("OOO"))
                {
                    return "O";
                }
            }

            if (this.TurnCount == 9)
            {
                return "Draw";
            }
            else
            {
                return "";
            }
        }
    }
}