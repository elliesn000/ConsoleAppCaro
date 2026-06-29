using DbClasses;
using System;
using System.Collections.Generic;
using System.Text;
namespace Classes;
public class UserMenu()
{
    public static void ShowUserMenu(string userEmail)
    {
        while (true)
        {
            int choose = InputParse.GetInt(@$"
================================
    USER MENU: Hello {userEmail}

1. New Game

2. See History

0. Return Login Menu

Press Number to choose
================================
");
            switch (choose)
            {
                case 0:
                    {
                        return;
                    }
                case 1:
                    {
                        CaroBoardManager.NewGame(userEmail);
                        continue;
                    }
                case 2:
                    {
                        UserManager.SeeAllHistory(userEmail);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Choose invalid");
                        continue;
                    }
            }
        }
    }
}