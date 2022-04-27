namespace SocialNetwork.Services.Impl;

using SocialNetwork.Mappers.Abstract;
using SocialNetwork.Mappers.Impl;
using SocialNetwork.Models;
using SocialNetwork.UOW.Impl;
using SocialNetwork.Repository.Abstract;

public class UserService
{
    private readonly IUserMapper _userMapper;
    private readonly IUserRepository _repository;
        
    public UserService()
    {
        _userMapper = new UserMapper();
        _repository = new UnitOfWork().Users;

    }

    public List<User> GetFriends(int userId)
    {
        return _repository.GetFriendsOfUser(userId).Select(x => _userMapper.ToModel(x)).ToList();
    }
}