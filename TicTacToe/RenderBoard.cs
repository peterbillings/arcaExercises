using System;

namespace TicTacToe
{
    class RenderBoard
    {
        public RenderBoard()
        {

        }
        
        public void PrintCurrentBoard(TicTacToeBoard gameBoard)
        {
            var TL = gameBoard.GetPositionState(Position.topLeft);
            var TM = gameBoard.GetPositionState(Position.topMid);
            var TR = gameBoard.GetPositionState(Position.topRight);
            var ML = gameBoard.GetPositionState(Position.midLeft);
            var MM = gameBoard.GetPositionState(Position.midMid);
            var MR = gameBoard.GetPositionState(Position.midRight);
            var BL = gameBoard.GetPositionState(Position.bottomLeft);
            var BM = gameBoard.GetPositionState(Position.bottomMid);
            var BR = gameBoard.GetPositionState(Position.bottomRight);

            Console.WriteLine();

            Console.WriteLine($" {TL} | {TM} | {TR} ");

            Console.WriteLine("-----------");

            Console.WriteLine($" {ML} | {MM} | {MR} ");

            Console.WriteLine("-----------");

            Console.WriteLine($" {BL} | {BM} | {BR} ");

            Console.WriteLine();
        }
    }
}