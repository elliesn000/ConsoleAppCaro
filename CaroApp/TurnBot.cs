using System;
namespace Classes;
public class TurnBot
{
    public static void AutoTurn(CaroBoard board)
    {        
        var (row, col) = BotLogic.GetAutoMove(board);
        if (row == -1) return;

        CaroBoardLogic.CheckMove(board, row, col, 2);

        Console.WriteLine();
        
        Console.ReadKey();
    }
}


