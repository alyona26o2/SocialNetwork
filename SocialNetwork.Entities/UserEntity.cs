using System.ComponentModel.DataAnnotations;

namespace SocialNetwork.Entities;
public class UserEntity
{
    [Key]
    public int Id { get; set; }
    
    public string Nickname { get; set; }

    public string Surname { get; set; }

    public string Name { get; set; }

    public DateTime Birthday { get; set; }
}