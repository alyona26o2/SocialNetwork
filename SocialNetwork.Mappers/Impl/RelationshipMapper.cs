using SocialNetwork.Entities;
using SocialNetwork.Mappers.Abstract;
using SocialNetwork.Models;

namespace SocialNetwork.Mappers.Impl;

public class RelationshipMapper : IRelationshipMapper
{
    
    private readonly IUserMapper _userMapper;

    public RelationshipMapper()
    {
        _userMapper = new UserMapper();
    }

    public Relationship ToModel(RelationshipEntity entity)
    {
        return new Relationship()
        {
            Id = entity.Id,
            User1 = _userMapper.ToModel(entity.User1),
            User2 = _userMapper.ToModel(entity.User2),
        };
    }

    public RelationshipEntity ToEntity(Relationship model)
    {
        return new RelationshipEntity()
        {
            Id = model.Id,
            User1 = _userMapper.ToEntity(model.User1),
            User2 = _userMapper.ToEntity(model.User2),
        };
    }
    
}