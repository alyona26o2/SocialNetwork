using System.ComponentModel.DataAnnotations;

namespace SocialNetwork.Entities;

public class MessageEntity
{
    [Key]
    public int Id { get; set; }

    public string Text { get; set; }

    public DateTime Time { get; set; }
    
    public int SenderId { get; set; }

    public UserEntity Sender { get; set; }
    
    public int ReceiverId { get; set; }
    
    public UserEntity Receiver { get; set; }
    
}