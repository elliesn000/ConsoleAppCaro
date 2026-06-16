using System;

namespace Classes
{
    public static class UserManager
    {        
        public static User CreateUser()
        {
            Console.Write("Input Email: ");
            string email = Console.ReadLine();

            Console.Write("Input Password: ");
            string password = Console.ReadLine();
            
            User user = new User(email, password);

            return user;
        }
                
        public static void ShowUserInfo(User user)
        {
            Console.WriteLine("\n------------------------------------");
            Console.WriteLine("Create Account Complete.");
            Console.WriteLine($"Your ID: {user.UserID}");
            Console.WriteLine($"Your Email: {user.Email}");
            Console.WriteLine("------------------------------------");
            Console.ReadLine();
        }

        public static void ShowUserInGame(User user)
        {
            Console.WriteLine("\n------------------------------------");            
            Console.WriteLine($"Your ID: {user.UserID}");            
            Console.WriteLine("------------------------------------");
        }
    }
}