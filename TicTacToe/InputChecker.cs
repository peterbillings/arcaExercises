using System;

namespace TicTacToe
{
    class InputChecker
    {
        public InputChecker()
        {

        }

        public Boolean IsInputTypeAndRangeCorrect(string playerInput)
        {
            if (int.TryParse(playerInput, out int result))
            {
                if (result > 0 && result < 10 )
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
