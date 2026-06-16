using System.ComponentModel.DataAnnotations;
namespace Classes;
public class Board
{
    [Key]
    public int GameID { get; set; } // Khóa chính (gạch chân trong sơ đồ)

    public int UserID { get; set; } // Thuộc tính kết nối sang User
    public string State { get; set; } = string.Empty;
    public int Size { get; set; }
    public string BoardCM { get; set; } = string.Empty;

    //learn.microsoft.com/en-us/ef/ef6/modeling/code-first/workflows/new-database
    public virtual List<Piece> Pieces { get; set; }

}