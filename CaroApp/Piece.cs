using System;
namespace DbClasses;

public class Piece

{
    public int PieceID { get; set; }
    public int Color { get; set; } //2 = O =bot, 1 = X =user
    public int X { get; set; }
    public int Y { get; set; }    
    public Game? Games { get; set; }

}