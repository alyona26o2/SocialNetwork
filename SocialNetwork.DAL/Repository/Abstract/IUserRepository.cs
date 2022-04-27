using SocialNetwork.Entities;

namespace SocialNetwork.Repository.Abstract;

public interface IUserRepository : IGenericRepository<UserEntity>
{
    public IList<UserEntity> GetFriendsOfUser(int userId);

}