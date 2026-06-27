using DbClasses;
using System;
namespace Classes;

public class CaroBoardManager	
{
    public static void NewGame()
    {
        while (true)
        {
            int boardSize = Classes.InputParse.GetInt("Input Size Board or Press 0 to Return User Menu");
            if (boardSize != 0)
            {
                CaroBoard board = new CaroBoard(boardSize);
            }
            else
                return;

            CaroBoardManager.DrawBoard(board);
            CaroBoardLogic.WinLose(board);


            if (!TurnPlayer.PlayerTurn(board))
                continue;

            Console.Clear();
            UserManager.ShowUserInGame(user);
            CaroBoardManager.DrawBoard(board);
            CaroBoardLogic.WinLose(board);


            TurnBot.AutoTurn(board);

            return;

        }
    }
    public static void DrawBoard(CaroBoard board)
    {
        int size = board.Size;

        // ===== In số cột =====
        Console.Write("    ");
        for (int c = 1; c <= size; c++)
            Console.Write($"  {c} ");
        Console.WriteLine();

        // ===== In dòng trên cùng =====
        Console.Write("    ");
        for (int c = 0; c < size; c++)
            Console.Write("+---");
        Console.WriteLine("+");

        // ===== In từng hàng =====
        for (int r = 0; r < size; r++)
        {
            // Dòng chứa quân cờ
            Console.Write($"{r + 1,3} |");
            for (int c = 0; c < size; c++)
            {
                char ch = board.Board[r, c] switch
                {
                    1 => 'X',
                    2 => 'O',
                    _ => ' '
                };

                Console.Write($" {ch} |");
            }
            Console.WriteLine();

            // Dòng gạch ngang dưới mỗi hàng
            Console.Write("    ");
            for (int c = 0; c < size; c++)
                Console.Write("+---");
            Console.WriteLine("+");
        }
    }
}
