using System.Data.Entity;
using SocialNetwork.Entities;

namespace SocialNetwork.Context;

public class SocialNetworkContext : DbContext {

    public DbSet<UserEntity> Users { get; set; }
    
    public DbSet<RelationshipEntity> Relationships { get; set; }
    
    public DbSet<MessageEntity> Messages { get; set; }
}