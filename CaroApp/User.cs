using System;
using System.ComponentModel.DataAnnotations;
namespace DbClasses;

public class User
{
    public string EmailId { get; set; } = string.Empty;

    public List<Game> Games = new();

}