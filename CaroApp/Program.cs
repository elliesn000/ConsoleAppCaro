
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
            DbClasses.UserManager.ShowAllUser();
            UserMenu.ShowUserMenu(UserManager.Login(UserManager.CheckEmail()));
        }
    }
}
    


