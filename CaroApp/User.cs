using System;
using System.ComponentModel.DataAnnotations;
namespace Classes;

public class User
{
    private static int s_userIDSeed = 1234567890;
    [Key]
    public int UserID { get; set; }

    [Required]
    public string Email { get; set; } = string.Empty;

    [Required]
    public string Password { get; set; } = string.Empty;


    public User(string email, string password)
    {
        Email = email;
        Password = password;
        UserID = s_userIDSeed;
        s_userIDSeed++;
    }
}