using System;
namespace Classes;
public class CaroBoard
{
        public int Size { get; set; }
        public int[,] Pieces { get; set; }

        public CaroBoard(int size)
        {
            Size = size;
            Pieces = new int[size,size];
        }
    
}