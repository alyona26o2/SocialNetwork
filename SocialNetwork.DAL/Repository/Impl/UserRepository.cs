using SocialNetwork.Repository.Abstract;
using SocialNetwork.Entities;
using SocialNetwork.Context;
using System.Data.Entity;

namespace SocialNetwork.Repository.Impl;

public class UserRepository : GenericRepository<UserEntity>, IUserRepository
{
    public UserRepository(SocialNetworkContext context) : base(context)
    {
    }

    public IList<UserEntity> GetFriendsOfUser(int userId)
    {
        return context.Relationships
            .Where(r => IsFriend(userId, r.User1Id, r.User2Id))
            .Include(r => r.User1)
            .Include(r => r.User2)
            .Select(r => GetFriend(userId, r))
            .ToList();
    }

    private bool IsFriend(int userId, int user1Id, int user2Id )
    {
        return user1Id == userId || user2Id == userId;
    }

    private UserEntity GetFriend(int userId, RelationshipEntity relationship)
    {
        return relationship.User1Id == userId ? relationship.User2 : relationship.User1;
    }
}