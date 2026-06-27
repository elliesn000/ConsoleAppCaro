using Classes;
using System;
using System.Drawing;
namespace DbClasses;

public class GameManager
{
    public static void NewHistory(CaroBoard board, string userEmail, int state)
    {
        using (var context = new AppDbContext())
        {
            string comment = Classes.InputParse.GetString("Input Comment");
            var user = context.Users.Find(userEmail);
            int size = board.Size;
            Game game = new Game { Users = user, Comment = comment, Size = size, State = state };
            context.Add(game);

            int[,] piece = board.Pieces;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (piece[i, j] != 0)
                    {
                        Piece pieces = new Piece { Color = piece[i, j], Cordinate = piece, Games = game };
                        context.Add(pieces);

                    }
                }
            }
            context.SaveChanges();
        }
    }


    public static void DrawBoardHistory(int gameId, string userId)
    {
        using (var context = new AppDbContext())
        {
            var user = context.Users.Find(userId);

            var historyGame = context.Games
                .Where(p => p.GameId == gameId && p.Users == user)
                .FirstOrDefault();
            if (historyGame != null)
            {
                int size = historyGame.Size;
                CaroBoard board = new(historyGame.Size);
                var allPieces = historyGame.Pieces.ToList();

                foreach (var p in allPieces)
                {
                    board.Pieces = p.Cordinate!;
                }
                CaroBoardManager.DrawBoard(board);
                Console.WriteLine($" You {historyGame.State}");
                Console.WriteLine($" Comment: {historyGame.Comment}");
            }
            else
            {
                Console.WriteLine("GameId invalid");
                return;
            }
        }
    }
}