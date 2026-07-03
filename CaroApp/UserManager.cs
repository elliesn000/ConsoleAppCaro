using System;
using Classes;

namespace DbClasses;

public class UserManager
{
    public static string CheckEmail()
    {
        while (true)
        {
            Console.WriteLine("Input Email to Login");
            string inputEmail = Console.ReadLine();
            if (!Classes.InputParse.IsValidEmail(inputEmail))
            {
                Console.WriteLine("Error: Email invalid. Input again");
                continue;
            }
            return inputEmail;
        }
    }

    public static string Login(string inputEmail)
    {
        using (var context = new AppDbContext())
        {
            var user = context.Users.Find(inputEmail);
            if (user != null)
            {
                Console.WriteLine($"Login User {inputEmail}");
                return inputEmail;
            }
            else
            {
                Console.WriteLine($" User with name {inputEmail} not found.");
                Console.WriteLine("\n------ Creating a user ------");

                User newUser = new User { EmailId = inputEmail };
                context.Add(newUser);
                context.SaveChanges();
                Console.WriteLine($"Add user Done: {newUser.EmailId}");
                Console.WriteLine("--------------------------------");

                return inputEmail;
            }
        }

    }

    public static void SeeAllHistory(string inputUser)
    {
        using (var context = new AppDbContext())
        {
            var history = context.Games
                .Where(p => p.Users.EmailId == inputUser)
                .ToList();
            if (history.Count != 0)
            {

                foreach (var h in history)
                {
                    string state;
                    if (h.State == 1)
                        state = "You Win";
                    else
                        state = "You Lose";
                    Console.WriteLine($"- Id {h.GameId} : {state}");
                }

                int choose = Classes.InputParse.GetInt("Input Id to see or Press 0 to return User Menu");
                if (choose != 0)
                {
                    GameManager.DrawBoardHistory(choose, inputUser);
                }
                else
                    return;
            }
            //history null
            else
            {
                Console.WriteLine("None history");
                Console.ReadLine();
                return;
            }
        }
    }


    public static void ShowAllUser()
    {
        using (var context = new AppDbContext())
        {
            var users = context.Users.ToList();
            foreach (var u in users)
            {
                Console.WriteLine($"- {u.EmailId}");
            }
        }
    }
}