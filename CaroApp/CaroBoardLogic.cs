using System;
using System.Drawing;
namespace Classes;

public class CaroBoardLogic
{
    static public bool CheckMove(CaroBoard board, int row, int col, int player)
    {
        if (row < 0 || row >= board.Size || col < 0 || col >= board.Size)
            return false;

        if (board.Pieces[row, col] != 0)
            return false;

        board.Pieces[row, col] = player; //return Pieces //insert in array => can use

        return true;
    }

    static public int WinLose(CaroBoard board)
    {
        int[,] Board = board.Pieces;
        int Size = board.Size;

        for (int i = 0; i < Size; i++)
        {
            for (int j = 0; j < Size; j++)
            {
                if (Board[i, j] != 0)
                {
                    int checkValue = Board[i, j];
                    for (int ik = 0; ik <= 1; ik++)
                    {
                        for (int jk = -1; jk <= 1; jk++)
                        {
                            int count = 1;
                            int i_ = i;
                            int j_ = j;
                            while (count < 5 && i_ < Size && j_ < Size)
                            {
                                if (ik != 0 || jk != 0)
                                {
                                    i_ += ik;
                                    j_ += jk;
                                    if (i_ >= 0 && i_ < Size && j_ >= 0 && j_ < Size)
                                    {
                                        if (board.Pieces[i_, j_] == checkValue)
                                        {
                                            count++;
                                            continue;
                                        }
                                    }
                                    break;
                                }
                                break;
                            }
                            if (count == 5)
                            {
                                if (checkValue == 1)
                                {
                                    Console.WriteLine("You Win");
                                    return 1;
                                }

                                if (checkValue == 2)
                                {
                                    Console.WriteLine("You Lose"); //Bot Win
                                    return 2;
                                }
                            }
                            
                        }
                        
                    }
                    
                }
                

            }
        }
        return 0;
        
    }
}
