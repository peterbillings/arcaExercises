using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic-Tac-Toe!");
            Console.WriteLine();
            Console.WriteLine("Choose a spot on the board by entering the corresponding number on the numeric keypad (1-9)");
            Console.WriteLine();
            
            string playAgain = "y";

            do
            {
                TicTacToeBoard gameBoard = new TicTacToeBoard();
                WinChecker winChecker = new WinChecker();
                RenderBoard boardPrinter = new RenderBoard();
                TurnTracker turnTracker = new TurnTracker();
                Player player = new Player();
                InputChecker inputChecker = new InputChecker();

                turnTracker.DecideFirstPlayer();

                Console.WriteLine($"Player {turnTracker.GetCurrentTurn()} goes first!");

                while (true)
                {
                    boardPrinter.PrintCurrentBoard(gameBoard);
                    
                    Console.WriteLine($"Player {turnTracker.GetCurrentTurn()}, make a move!");

                    string playerMove = Console.ReadLine();
                    
                    while (! inputChecker.IsInputTypeAndRangeCorrect(playerMove))
                    {
                        Console.WriteLine("Invalid input! Try again! (1-9)");
                        playerMove = Console.ReadLine();
                    }

                    while (true)
                    {
                        if (gameBoard.GetPositionState(player.ChooseASquareOnTheBoard(playerMove)) == PositionState._)
                        {
                            gameBoard.SetPositionState(player.ChooseASquareOnTheBoard(playerMove), turnTracker.GetCurrentTurn());
                            break;
                        }
                        
                        Console.WriteLine("That space is already occupied! Please try again!");
                        
                        playerMove = Console.ReadLine();

                        while (! inputChecker.IsInputTypeAndRangeCorrect(playerMove))
                        {
                            Console.WriteLine("Invalid input! Try again! (1-9)");
                            playerMove = Console.ReadLine();
                        }
                    }

                    if (turnTracker.GetTurnCount() > 4)
                    {
                        winChecker.CheckForWinner(gameBoard);

                        winChecker.CheckForDraw(turnTracker.GetTurnCount());
                    }

                    if (winChecker.XWins || winChecker.OWins || winChecker._Wins)
                    {
                        boardPrinter.PrintCurrentBoard(gameBoard);
                        break;
                    }

                    turnTracker.NextTurn();
                }
                
                if (winChecker._Wins != true)
                {
                    Console.WriteLine($"The winner is player {turnTracker.GetCurrentTurn()}!");
                }
                else
                {
                    Console.WriteLine("It's a draw! You must practice hard to fulfill your destiny!");
                }

                Console.WriteLine();

                Console.WriteLine("Do you want to play again? (y/n)");

                playAgain = Console.ReadLine();

            } 
            while (playAgain.Equals("y"));

            Console.WriteLine("Thanks for playing!");
            


            // Console.WriteLine(player.ChooseASquareOnTheBoard("1"));
            // Console.WriteLine(player.ChooseASquareOnTheBoard("2"));
            // Console.WriteLine(player.ChooseASquareOnTheBoard("3"));
            // Console.WriteLine(player.ChooseASquareOnTheBoard("4"));
            // Console.WriteLine(player.ChooseASquareOnTheBoard("5"));
            // Console.WriteLine(player.ChooseASquareOnTheBoard("6"));
            // Console.WriteLine(player.ChooseASquareOnTheBoard("7"));
            // Console.WriteLine(player.ChooseASquareOnTheBoard("8"));
            // Console.WriteLine(player.ChooseASquareOnTheBoard("9"));
            

            // turnTracker.DecideFirstPlayer();
            // Console.WriteLine(turnTracker.GetTurnCount() + " " + turnTracker.GetCurrentTurn());
            // turnTracker.NextTurn();
            // Console.WriteLine(turnTracker.GetTurnCount() + " " + turnTracker.GetCurrentTurn());
            // turnTracker.NextTurn();
            // Console.WriteLine(turnTracker.GetTurnCount() + " " + turnTracker.GetCurrentTurn());
            // turnTracker.NextTurn();
            // Console.WriteLine(turnTracker.GetTurnCount() + " " + turnTracker.GetCurrentTurn());
            // turnTracker.NextTurn();
            // Console.WriteLine(turnTracker.GetTurnCount() + " " + turnTracker.GetCurrentTurn());
            // turnTracker.NextTurn();
            // Console.WriteLine(turnTracker.GetTurnCount() + " " + turnTracker.GetCurrentTurn());
            // turnTracker.NextTurn();
            // Console.WriteLine(turnTracker.GetTurnCount() + " " + turnTracker.GetCurrentTurn());
            // turnTracker.NextTurn();
            
            

            // gameBoard.SetPositionState(Position.bottomLeft, PositionState.X);
            // gameBoard.SetPositionState(Position.bottomMid, PositionState.O);
            // gameBoard.SetPositionState(Position.bottomRight, PositionState.X);
            // gameBoard.SetPositionState(Position.midLeft, PositionState.X);
            // gameBoard.SetPositionState(Position.midMid, PositionState.O);
            // gameBoard.SetPositionState(Position.midRight, PositionState.X);
            // gameBoard.SetPositionState(Position.topLeft, PositionState.O);
            // gameBoard.SetPositionState(Position.topMid, PositionState.X);
            // gameBoard.SetPositionState(Position.topRight, PositionState.O);

            // boardPrinter.PrintCurrentBoard(gameBoard);


            // winChecker.CheckForWinner(gameBoard);

            // Console.WriteLine("Final value for Xwins: " + winChecker.XWins);
            // Console.WriteLine("Final value for Owins: " + winChecker.OWins);

            

            
            // Console.WriteLine(gameBoard.GetPositionState(Position.bottomLeft));
            // Console.WriteLine(gameBoard.GetPositionState(Position.bottomMid));
            // Console.WriteLine(gameBoard.GetPositionState(Position.bottomRight));
            // Console.WriteLine(gameBoard.GetPositionState(Position.midLeft));
            // Console.WriteLine(gameBoard.GetPositionState(Position.midMid));
            // Console.WriteLine(gameBoard.GetPositionState(Position.midRight));
            // Console.WriteLine(gameBoard.GetPositionState(Position.topLeft));
            // Console.WriteLine(gameBoard.GetPositionState(Position.topMid));
            // Console.WriteLine(gameBoard.GetPositionState(Position.topRight));

        }
    }
}
