using System;
using System.ComponentModel.DataAnnotations;
namespace Classes;

public class User
{
    private static int s_userIDSeed = 1234567890;

    [Key]
    public int UserID { get; }
    

    [Required]
    [MaxLength(30)]
    public string Email { get; set; }

    [Required]
    [MaxLength(255)]
    public string Password { get; set; }

    public User(string email, string password)
    {
        Email = email;
        Password = password;
        UserID = s_userIDSeed;
        s_userIDSeed++;
    }
}