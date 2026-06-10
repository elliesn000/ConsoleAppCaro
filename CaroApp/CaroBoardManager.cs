using System;
namespace Classes;

public class CaroBoardManager	
{
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
