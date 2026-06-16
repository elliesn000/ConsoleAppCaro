
using Classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Drawing;

namespace CaroApp
{
    public class Program
    {        
        static void Main()
        {
            //using (var context = new AppDbContext())
            //{
            //    context.Database.Migrate(); 
            //}

            //Console.WriteLine("Database migrated");

            ////Create
            //Console.WriteLine("\n--- Creating new user ---");
            //using (var context = new AppDbContext())
            //{
            //    User user = UserManager.CreateUser();

            //    context.Users.Add(user);                

            //    context.SaveChanges();
                
            //    UserManager.ShowUserInfo(user);
            //    Console.ReadLine();                
            //}



            User user = UserManager.CreateUser();

            UserManager.ShowUserInfo(user);
            Console.ReadLine();


            int inputsize = 10;            
            CaroBoard board = new CaroBoard(inputsize);

            while (true)
            {
                Console.Clear();
                UserManager.ShowUserInGame(user);
                CaroBoardManager.DrawBoard(board);
                CaroBoardLogic.WinLose(board);

                
                if (!TurnPlayer.PlayerTurn(board))
                    continue;

                Console.Clear();
                UserManager.ShowUserInGame(user);
                CaroBoardManager.DrawBoard(board);
                CaroBoardLogic.WinLose(board);

                
                TurnBot.AutoTurn(board);
            }
        }
    }
}

