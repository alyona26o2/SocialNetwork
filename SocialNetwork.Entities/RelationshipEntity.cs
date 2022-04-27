using System.ComponentModel.DataAnnotations;

namespace SocialNetwork.Entities;

public class RelationshipEntity
{
    [Key]
    public int Id { get; set; }

    public int User1Id { get; set; }
    
    public int User2Id { get; set; }

    public virtual UserEntity User1 { get; set; }
    
    public virtual UserEntity User2 { get; set; }
}