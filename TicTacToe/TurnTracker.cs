using System;

namespace TicTacToe
{
    class TurnTracker
    {
        private PositionState currentTurn;
        private int turnCount;

        public TurnTracker()
        {
            turnCount = 0;
        }

        public void DecideFirstPlayer()
        {
            Random random = new Random();

            int coinToss = random.Next(2) + 1;

            turnCount++;

            if (coinToss < 2)
                currentTurn = PositionState.X;

            else
                currentTurn = PositionState.O;
        }

        public void NextTurn()
        {
            if (currentTurn == PositionState.X)
                currentTurn = PositionState.O;

            else
                currentTurn = PositionState.X;
            
            turnCount++;
        }

        public PositionState GetCurrentTurn()
        {
            return currentTurn;
        }

        public int GetTurnCount()
        {
            return turnCount;
        }
    }
}

