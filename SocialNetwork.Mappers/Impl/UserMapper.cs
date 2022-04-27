using SocialNetwork.Entities;
using SocialNetwork.Mappers.Abstract;
using SocialNetwork.Models;

namespace SocialNetwork.Mappers.Impl;

public class UserMapper : IUserMapper
{
    public UserEntity ToEntity(User model)
    {
        return new UserEntity()
        {
            Id = model.Id,
            Name = model.Name,
            Surname = model.Surname,
            Nickname = model.Nickname,
            Birthday = model.Birthday
        };
    }

    public User ToModel(UserEntity entity)
    {
        return new User()
        {
            Id = entity.Id,
            Name = entity.Name,
            Surname = entity.Surname,
            Nickname = entity.Nickname,
            Birthday = entity.Birthday
        };
    }
}