
using Classes;
using DbClasses;
using Microsoft.EntityFrameworkCore;
using System;
using System.Drawing;

namespace Classes;

public class Program
{
    static void Main()
    {
        while (true)
        {
            string inputEmail = UserManager.CheckEmail();
            string userEmail = UserManager.Login(inputEmail);


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
                            CaroBoardManager.NewGame();
                            return;
                        }
                    case 2:
                        {
                            return;
                        }

                }
            }

        }
    }
}
    


