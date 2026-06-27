using System;
namespace DbClasses;

public class Piece

{
    public int PieceID { get; set; }
    public int Color { get; set; }
    public int[,]? Cordinate { get; set; }
    public Game? Games { get; set; }

}