using System;
namespace Classes;
public class CaroBoard
{
        public int Size { get; }
        public int[,] Pieces { get; }

        public CaroBoard(int size)
        {
            Size = size;
            Pieces = new int[size, size];
        }
}