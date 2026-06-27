using System;
using DbClasses;

namespace DbClasses;

public class UserManager
{
    public static string CheckEmail()
    {
        while (true)
        {
            Console.WriteLine("Input Email to Login");
            string? inputEmail = Console.ReadLine();
            if (!Classes.InputParse.IsValidEmail(inputEmail!))
            {
                Console.WriteLine("Error: Email invalid");
                continue;
            }
            return inputEmail!;
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
}