using DbClasses;
using System;
namespace Classes;

public class CaroBoardManager
{
    public static void NewGame(string user)
    {

        //int boardSize = Classes.InputParse.GetInt("Input Size Board or Press 0 to Return User Menu");
        int boardSize = 10;
        if (boardSize <= 0)
        {
            if (boardSize < 0)
                Console.WriteLine("Size invalid");
            return;
        }
        CaroBoard board = new CaroBoard(boardSize);
        while (true)
        {
            Console.Clear();
            CaroBoardManager.DrawBoard(board);
            if (!TurnPlayer.PlayerTurn(board))
                continue;

            int state1 = CaroBoardLogic.WinLose(board);
            if (state1 != 0)
            {
                GameManager.NewHistory(board, user, state1);
                return;
            }

            CaroBoardManager.DrawBoard(board);
            Console.Clear();
            TurnBot.AutoTurn(board);

            int state2 = CaroBoardLogic.WinLose(board);
            if (state2 != 0)
            {
                GameManager.NewHistory(board, user, state2);
                return;
            }
        }
    }
    public static void DrawBoard(CaroBoard board)
    {
        int size = board.Size;

        // ===== Print Columns =====
        Console.Write("    ");
        for (int c = 1; c <= size; c++)
            Console.Write($"  {c} ");
        Console.WriteLine();

        // ===== Print First Row =====
        Console.Write("    ");
        for (int c = 0; c < size; c++)
            Console.Write("+---");
        Console.WriteLine("+");

        // ===== Print Row =====
        for (int r = 0; r < size; r++)
        {
            // Print Pieces
            Console.Write($"{r + 1,3} |");
            for (int c = 0; c < size; c++)
            {
                char ch = board.Pieces[r, c] switch
                {
                    1 => 'X',
                    2 => 'O',
                    _ => ' '
                };

                Console.Write($" {ch} |");
            }
            Console.WriteLine();

            // Print Under Line
            Console.Write("    ");
            for (int c = 0; c < size; c++)
                Console.Write("+---");
            Console.WriteLine("+");
        }
    }
}
