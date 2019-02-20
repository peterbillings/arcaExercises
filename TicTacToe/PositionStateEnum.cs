using System;

namespace TicTacToe
{
    public enum PositionState {_ = 0, X = 1, O = 4};
}
// enumeration values were originally 0,1,2 respectively, but I had to make O equal 4 to make WinChecker function correctly
// essentially the problem was that 1+1+1 == 3, but also 0+1+2 (etc) == 3
