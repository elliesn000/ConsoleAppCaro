using System;
using System.Drawing;
namespace Classes;
public class TurnPlayer
{

    public static bool PlayerTurn(Piece board)
    {
        Console.WriteLine();
        Console.Write("Input row col (R C): ");

        string? input = Console.ReadLine(); //warning: dereference null
        if (string.IsNullOrWhiteSpace(input))
            return false;

        string[] parts = input.Split(' ');
        if (parts.Length != 2)
            return false;

        int userRow = int.Parse(parts[0]);
        int userCol = int.Parse(parts[1]);

        int row = userRow - 1;
        int col = userCol - 1;

        bool success = CaroBoardLogic.CheckMove(board, row, col, 1);

        if (!success)
        {
            Console.WriteLine("❌ Invalid Input!");
            Console.ReadKey();
            return false;
        }
        return true;
    }
}
