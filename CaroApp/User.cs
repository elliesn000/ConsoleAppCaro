using System;
using System.ComponentModel.DataAnnotations;
namespace DbClasses;

public class User
{
    [Key]
    public string EmailId { get; set; } = string.Empty;

    public List<Game> Games { get; set; } = new();

}