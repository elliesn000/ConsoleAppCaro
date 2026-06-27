using System;
using System.Drawing;
namespace Classes;

public class BotLogic
{
    //Auto TRẢ VỀ NƯỚC ĐI(O = 2)
    static public (int row, int col) GetAutoMove(Piece board)
    {
        int Size = board.Size;
        int[,] Board = board.Board;
        //4_X
        for (int i = 0; i < Size; i++)
        {
            for (int j = 0; j < Size; j++)
            {
                if (Board[i, j] == 1)
                {
                    int checkValue = Board[i, j];
                    for (int ik = 0; ik <= 1; ik++)
                    {
                        for (int jk = -1; jk <= 1; jk++)
                        {
                            int count = 1;
                            int i_ = i;
                            int j_ = j;
                            while (count < 4 && i_ < Size && j_ < Size)
                            {
                                if (ik != 0 || jk != 0)
                                {
                                    i_ += ik;
                                    j_ += jk;
                                    if (i_ >= 0 && i_ < Size && j_ >= 0 && j_ < Size)
                                    {
                                        if (Board[i_, j_] == checkValue)
                                        {
                                            count++;
                                            continue;
                                        }
                                    }
                                    break;
                                }
                                break;
                            }
                            if (count == 4)
                            {
                                if (i - ik < 0 || i - ik >= Size || j - jk < 0 || i - ik >= Size)
                                {
                                    if (i + 4 * ik >= 0 && i + 4 * ik < Size && j + 4 * jk >= 0 && j + 4 * jk < Size && Board[i + 4 * ik, j + 4 * jk] == 0)
                                        return (i + 4 * ik, j + 4 * jk);
                                }
                                else if (Board[i - ik, j - jk] == 0)
                                    return (i - ik, j - jk);
                                else //(Board[i - ik, j - jk] == 2)
                                {
                                    if (i + 4 * ik >= 0 && i + 4 * ik < Size && j + 4 * jk >= 0 && j + 4 * jk < Size && Board[i + 4 * ik, j + 4 * jk] == 0)
                                        return (i + 4 * ik, j + 4 * jk);
                                }
                            }
                            continue;
                        }

                    }
                }
                continue;
            }
        }


        //3_X
        for (int i = 0; i < Size; i++)
        {
            for (int j = 0; j < Size; j++)
            {
                if (Board[i, j] == 1)
                {
                    int checkValue = Board[i, j];
                    for (int ik = 0; ik <= 1; ik++)
                    {
                        for (int jk = -1; jk <= 1; jk++)
                        {
                            int count = 1;
                            int i_ = i;
                            int j_ = j;
                            while (count < 3 && i_ < Size && j_ < Size)
                            {
                                if (ik != 0 || jk != 0)
                                {
                                    i_ += ik;
                                    j_ += jk;
                                    if (i_ >= 0 && i_ < Size && j_ >= 0 && j_ < Size)
                                    {
                                        if (Board[i_, j_] == checkValue)
                                        {
                                            count++;
                                            continue;
                                        }
                                    }
                                    break;
                                }
                                break;
                            }
                            if (count == 3) //khi co 2 duong 3. duong da chan cach 1 o thi` chan duong con lai
                            {

                                {
                                    if (i + 4 * ik >= 0 && i + 4 * ik < Size && j + 4 * jk >= 0 && j + 4 * jk < Size
                                        && Board[i + 4 * ik, j + 4 * jk] == checkValue && Board[i + 3 * ik, j + 3 * jk] == 0)
                                        return (i + 3 * ik, j + 3 * jk); //XXX_X

                                    else if (i - 2 * ik >= 0 && i - 2 * ik < Size && j - 2 * jk >= 0 && j - 2 * jk < Size
                                        && Board[i - 2 * ik, j - 2 * jk] == checkValue && Board[i - ik, j - jk] == 0)
                                        return (i - ik, j - jk); //X_XXX


                                    else if (i + 3 * ik >= 0 && i + 3 * ik < Size && j + 3 * jk >= 0 && j + 3 * jk < Size
                                        && Board[i + 3 * ik, j + 3 * jk] == 0
                                        && i - ik >= 0 && i - ik < Size && j - jk >= 0 && j - jk < Size
                                        && Board[i - ik, j - jk] == 0)
                                    {
                                        if (i + 3 * ik < Size / 2 && j + 3 * jk < Size / 2)
                                            return (i + 3 * ik, j + 3 * jk);
                                        return (i - ik, j - jk);
                                    } //_XXX_


                                    // |XXX_ & _XXX|
                                    //else if (i + 3 * ik >= 0 && i + 3 * ik < Size && j + 3 * jk >= 0 && j + 3 * jk < Size
                                    //    && Board[i + 3 * ik, j + 3 * jk] == 0)
                                    //    return (i + 3 * ik, j + 3 * jk);

                                    //else if (i - ik >= 0 && i - ik < Size && j - jk >= 0 && j - jk < Size
                                    //    && Board[i - ik, j - jk] == 0)
                                    //    return (i - ik, j - jk);
                                }
                            }
                            continue;
                        }
                    }
                }
                continue;
            }
        }


        //2_X
        for (int i = 0; i < Size; i++)
        {
            for (int j = 0; j < Size; j++)
            {
                if (Board[i, j] == 1)
                {
                    int checkValue = Board[i, j];
                    int mValue = 2;
                    for (int ik = 0; ik <= 1; ik++)
                    {
                        for (int jk = -1; jk <= 1; jk++)
                        {
                            int count = 1;
                            int i_ = i;
                            int j_ = j;
                            while (count < 2 && i_ < Size && j_ < Size)
                            {
                                if (ik != 0 || jk != 0)
                                {
                                    i_ += ik;
                                    j_ += jk;
                                    if (i_ >= 0 && i_ < Size && j_ >= 0 && j_ < Size)
                                    {
                                        if (Board[i_, j_] == checkValue)
                                        {
                                            count++;
                                            continue;
                                        }
                                    }
                                    break;
                                }
                                break;
                            }
                            if (count == 2) // or |XXX_ & _XXX|
                            {
                                if (i + 3 * ik >= 0 && i + 3 * ik < Size && j + 3 * jk >= 0 && j + 3 * jk < Size) //XX__
                                {
                                    if (Board[i + 3 * ik, j + 3 * jk] == checkValue) //XX_X
                                    {
                                        if (i - ik >= 0 && i - ik < Size && j - jk >= 0 && j - jk < Size
                                            && Board[i - ik, j - jk] == 0) //_XX_X
                                        {
                                            if (i + 4 * ik >= 0 && i + 4 * ik < Size && j + 4 * jk >= 0 && j + 4 * jk < Size
                                                && Board[i + 4 * ik, j + 4 * jk] != mValue)
                                            {
                                                if (Board[i + 2 * ik, j + 2 * jk] == 0)
                                                    return (i + 2 * ik, j + 2 * jk); //_XX_X_ or _XX_XX
                                                //_XXOX_ //skip
                                            }
                                            return (i - ik, j - jk); // _XX_X| or _XX_XO
                                        }

                                        // |XX_X or OXX_X                                        
                                        else if (i + 4 * ik >= 0 && i + 4 * ik < Size && j + 4 * jk >= 0 && j + 4 * jk < Size
                                                && Board[i + 4 * ik, j + 4 * jk] != mValue)
                                        {
                                            if (Board[i + 2 * ik, j + 2 * jk] == 0)
                                                return (i + 2 * ik, j + 2 * jk); //  |XX_X_ or OXX_XX
                                            //  |XXOX_ or OXXOXX //skip
                                        }
                                    }

                                    // XX__
                                    else if (Board[i + 3 * ik, j + 3 * jk] == 0)
                                    {
                                        if (Board[i + 2 * ik, j + 2 * jk] == checkValue)
                                            return (i + 3 * ik, j + 3 * jk); // |XXX_                                       
                                    }

                                    // XX_O //skip
                                }
                                // XX_| //skip

                                ////////////////////////////////////////////////////////
                                if (i - 2 * ik >= 0 && i - 2 * ik < Size && j - 2 * jk >= 0 && j - 2 * jk < Size) // __XX
                                {
                                    if (Board[i - 2 * ik, j - 2 * jk] == checkValue) // X_XX
                                    {
                                        if (i + ik >= 0 && i + ik < Size && j + jk >= 0 && j + jk < Size
                                            && Board[i + ik, j + jk] == 0)

                                            if (Board[i + 2 * ik, j + 2 * jk] == 0)
                                                return (i + 2 * ik, j + 2 * jk); //_XX_X_ or _XX_XX
                                                                                 //_XXOX_ //skip
                                    }
                                    else if (Board[i - ik, j - jk] == 0)
                                        return (i - ik, j - jk); // _XX_X| or _XX_XO 
                                }

                                // |XX_X or OXX_X                                        
                                else if (i + 4 * ik >= 0 && i + 4 * ik < Size && j + 4 * jk >= 0 && j + 4 * jk < Size
                                        && Board[i + 4 * ik, j + 4 * jk] != mValue)
                                {
                                    if (Board[i + 2 * ik, j + 2 * jk] == 0)
                                        return (i + 2 * ik, j + 2 * jk); //  |XX_X_ or OXX_XX
                                                                         //  |XXOX_ or OXXOXX //skip
                                }

                                else if (Board[i - ik, j - jk] == 0) //_XXX|
                                {
                                    return (i - ik, j - jk);
                                }

                                // XX__


                                ///////////////////////////////////////////


                                // normal block 2



                            }
                        }
                    }
                    continue;
                }
            }
        }

        ////////////////////////////////////////
        // move x4
        for (int i = 0; i < Size; i++)
        {
            for (int j = 0; j < Size; j++)
            {
                if (Board[i, j] == 2)
                {
                    int checkValue = Board[i, j];
                    for (int ik = 0; ik <= 1; ik++)
                    {
                        for (int jk = -1; jk <= 1; jk++)
                        {
                            int count = 1;
                            int i_ = i;
                            int j_ = j;
                            while (count < 4 && i_ < Size && j_ < Size)
                            {
                                if (ik != 0 || jk != 0)
                                {
                                    i_ += ik;
                                    j_ += jk;
                                    if (i_ >= 0 && i_ < Size && j_ >= 0 && j_ < Size)
                                    {
                                        if (Board[i_, j_] == checkValue)
                                        {
                                            count++;
                                            continue;
                                        }
                                    }
                                    break;
                                }
                                break;
                            }
                            if (count == 4)
                            {
                                if (i - ik < 0 || i - ik >= Size || j - jk < 0 || i - ik >= Size)
                                {
                                    if (i + 4 * ik >= 0 && i + 4 * ik < Size && j + 4 * jk >= 0 && j + 4 * jk < Size && Board[i + 4 * ik, j + 4 * jk] == 0)
                                        return (i + 4 * ik, j + 4 * jk);
                                }
                                else if (Board[i - ik, j - jk] == 0)
                                    return (i - ik, j - jk);
                                else //(Board[i - ik, j - jk] == 2)
                                {
                                    if (i + 4 * ik >= 0 && i + 4 * ik < Size && j + 4 * jk >= 0 && j + 4 * jk < Size && Board[i + 4 * ik, j + 4 * jk] == 0)
                                        return (i + 4 * ik, j + 4 * jk);
                                }
                            }
                            continue;
                        }

                    }
                }
                continue;
            }
        }


        // move x3
        for (int i = 0; i < Size; i++)
        {
            for (int j = 0; j < Size; j++)
            {
                if (Board[i, j] == 2)
                {
                    int checkValue = Board[i, j];
                    for (int ik = 0; ik <= 1; ik++)
                    {
                        for (int jk = -1; jk <= 1; jk++)
                        {
                            int count = 1;
                            int i_ = i;
                            int j_ = j;
                            while (count < 3 && i_ < Size && j_ < Size)
                            {
                                if (ik != 0 || jk != 0)
                                {
                                    i_ += ik;
                                    j_ += jk;
                                    if (i_ >= 0 && i_ < Size && j_ >= 0 && j_ < Size)
                                    {
                                        if (Board[i_, j_] == checkValue)
                                        {
                                            count++;
                                            continue;
                                        }
                                    }
                                    break;
                                }
                                break;
                            }
                            if (count == 3) //khi co 2 duong 3. duong da chan cach 1 o thi` chan duong con lai
                            {

                                {
                                    if (i + 4 * ik >= 0 && i + 4 * ik < Size && j + 4 * jk >= 0 && j + 4 * jk < Size
                                        && Board[i + 4 * ik, j + 4 * jk] == checkValue && Board[i + 3 * ik, j + 3 * jk] == 0)
                                        return (i + 3 * ik, j + 3 * jk); //XXX_X

                                    else if (i - 2 * ik >= 0 && i - 2 * ik < Size && j - 2 * jk >= 0 && j - 2 * jk < Size
                                        && Board[i - 2 * ik, j - 2 * jk] == checkValue && Board[i - ik, j - jk] == 0)
                                        return (i - ik, j - jk); //X_XXX


                                    else if (i + 3 * ik >= 0 && i + 3 * ik < Size && j + 3 * jk >= 0 && j + 3 * jk < Size
                                        && Board[i + 3 * ik, j + 3 * jk] == 0
                                        && i - ik >= 0 && i - ik < Size && j - jk >= 0 && j - jk < Size
                                        && Board[i - ik, j - jk] == 0)
                                    {
                                        if (i + 3 * ik < Size / 2 && j + 3 * jk < Size / 2)
                                            return (i + 3 * ik, j + 3 * jk);
                                        return (i - ik, j - jk);
                                    } //_XXX_                                    
                                }
                            }
                            continue;
                        }
                    }
                }
                continue;
            }
        }

        //move x2
        for (int i = 0; i < Size; i++)
        {
            for (int j = 0; j < Size; j++)
            {
                if (Board[i, j] == 2)
                {
                    int checkValue = Board[i, j];
                    int mValue = 1;
                    for (int ik = 0; ik <= 1; ik++)
                    {
                        for (int jk = -1; jk <= 1; jk++)
                        {
                            int count = 1;
                            int i_ = i;
                            int j_ = j;
                            while (count < 2 && i_ < Size && j_ < Size)
                            {
                                if (ik != 0 || jk != 0)
                                {
                                    i_ += ik;
                                    j_ += jk;
                                    if (i_ >= 0 && i_ < Size && j_ >= 0 && j_ < Size)
                                    {
                                        if (Board[i_, j_] == checkValue)
                                        {
                                            count++;
                                            continue;
                                        }
                                    }
                                    break;
                                }
                                break;
                            }
                            if (count == 2) // or |XXX_ & _XXX|
                            {
                                if (i + 3 * ik >= 0 && i + 3 * ik < Size && j + 3 * jk >= 0 && j + 3 * jk < Size) //XX__
                                {
                                    if (Board[i + 3 * ik, j + 3 * jk] == checkValue) //XX_X
                                    {
                                        if (i - ik >= 0 && i - ik < Size && j - jk >= 0 && j - jk < Size
                                            && Board[i - ik, j - jk] == 0) //_XX_X
                                        {
                                            if (i + 4 * ik >= 0 && i + 4 * ik < Size && j + 4 * jk >= 0 && j + 4 * jk < Size
                                                && Board[i + 4 * ik, j + 4 * jk] != mValue)
                                            {
                                                if (Board[i + 2 * ik, j + 2 * jk] == 0)
                                                    return (i + 2 * ik, j + 2 * jk); //_XX_X_ or _XX_XX
                                                //_XXOX_ //skip
                                            }
                                            return (i - ik, j - jk); // _XX_X| or _XX_XO
                                        }

                                        // |XX_X or OXX_X                                        
                                        else if (i + 4 * ik >= 0 && i + 4 * ik < Size && j + 4 * jk >= 0 && j + 4 * jk < Size
                                                && Board[i + 4 * ik, j + 4 * jk] != mValue)
                                        {
                                            if (Board[i + 2 * ik, j + 2 * jk] == 0)
                                                return (i + 2 * ik, j + 2 * jk); //  |XX_X_ or OXX_XX
                                            //  |XXOX_ or OXXOXX //skip
                                        }
                                    }

                                    // XX__
                                    else if (Board[i + 3 * ik, j + 3 * jk] == 0)
                                    {
                                        if (Board[i + 2 * ik, j + 2 * jk] == checkValue)
                                            return (i + 3 * ik, j + 3 * jk); // |XXX_                                       
                                    }

                                    // XX_O //skip
                                }
                                // XX_| //skip

                                ////////////////////////////////////////////////////////
                                if (i - 2 * ik >= 0 && i - 2 * ik < Size && j - 2 * jk >= 0 && j - 2 * jk < Size) // __XX
                                {
                                    if (Board[i - 2 * ik, j - 2 * jk] == checkValue) // X_XX
                                    {
                                        if (i + ik >= 0 && i + ik < Size && j + jk >= 0 && j + jk < Size
                                            && Board[i + ik, j + jk] == 0)

                                            if (Board[i + 2 * ik, j + 2 * jk] == 0)
                                                return (i + 2 * ik, j + 2 * jk); //_XX_X_ or _XX_XX
                                                                                 //_XXOX_ //skip
                                    }
                                    else if (Board[i - ik, j - jk] == 0)
                                        return (i - ik, j - jk); // _XX_X| or _XX_XO 
                                }

                                // |XX_X or OXX_X                                        
                                else if (i + 4 * ik >= 0 && i + 4 * ik < Size && j + 4 * jk >= 0 && j + 4 * jk < Size
                                        && Board[i + 4 * ik, j + 4 * jk] != mValue)
                                {
                                    if (Board[i + 2 * ik, j + 2 * jk] == 0)
                                        return (i + 2 * ik, j + 2 * jk); //  |XX_X_ or OXX_XX
                                                                         //  |XXOX_ or OXXOXX //skip
                                }

                                else if (i - ik >= 0 && i - ik < Size && j - jk >= 0 && j - jk < Size
                                    && Board[i - ik, j - jk] == 0) //_XXX|
                                {
                                    return (i - ik, j - jk);
                                }

                                // XX__


                                ///////////////////////////////////////////


                                // normal block 2



                            }
                        }
                    }
                    continue;
                }
            }
        }


        // normal move
        for (int r = Size / 2; r < Size; r++)
        {
            for (int c = Size / 2; c < Size; c--)
                if (r >= 0 && r < Size && c >= 0 && c < Size && Board[r, c] == 0)
                {
                    return (r, c);
                }
                else
                {
                    for (int r1 = Size / 2; r1 < Size; r1--)
                    {
                        for (int c1 = Size / 2; c1 < Size; c1++)
                            if (r1 >= 0 && r1 < Size && c1 >= 0 && c1 < Size && Board[r1, c1] == 0)
                            {

                                return (r1, c1);
                            }
                            else
                            {
                                for (int r2 = Size / 2; r2 < Size; r2--)
                                {
                                    for (int c2 = Size / 2; c2 < Size; c2--)
                                        if (r2 >= 0 && r2 < Size && c2 >= 0 && c2 < Size && Board[r2, c2] == 0)
                                        {

                                            return (r2, c2);
                                        }
                                }
                            }
                    }
                }
            continue;
        }
        return (10, 10);
    }    
}
