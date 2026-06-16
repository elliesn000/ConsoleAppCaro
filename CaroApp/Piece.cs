using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;
namespace Classes;
public class Piece
{
    [Key]
    public int PieceID { get; set; }

    public int GameID { get; set; }

    public string Color { get; set; } = string.Empty;
    public string Cordinates { get; set; } = string.Empty;    
}