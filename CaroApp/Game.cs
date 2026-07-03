using DbClasses;
using System.ComponentModel.DataAnnotations;
namespace DbClasses;

public class Game
{
    public int GameId { get; set; }
    public int Size { get; set; }
    public int State { get; set; }
    public string Comment { get; set; } = string.Empty;
    public User? Users { get; set; }
    public List<Piece> Pieces = new();

}