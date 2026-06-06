
using System;
using System.Drawing;
using Classes;

namespace CaroApp
{
    public class Program
    {        
        static void Main()
        {
            int inputsize = 10;            
            CaroBoard board = new CaroBoard(inputsize);

            while (true)
            {
                Console.Clear();
                CaroBoardManager.DrawBoard(board);
                CaroBoardLogic.WinLose(board);

                
                if (!TurnPlayer.PlayerTurn(board))
                    continue;

                Console.Clear();
                CaroBoardManager.DrawBoard(board);
                CaroBoardLogic.WinLose(board);

                
                TurnBot.AutoTurn(board);
            }
        }
    }
}

