using System;
namespace Classes;

public class CaroBoard

{
    public int Size { get; }
    public int[,] Board { get; }

    public CaroBoard(int size)
    {
        Size = size;
        Board = new int[size, size];
    }



}