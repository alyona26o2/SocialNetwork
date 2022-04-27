using SocialNetwork.Repository.Abstract;
using SocialNetwork.Entities;
using SocialNetwork.Context;

namespace SocialNetwork.Repository.Impl;

public class RelationshipRepository : GenericRepository<RelationshipEntity>, IRelationshipRepository
{
    public RelationshipRepository(SocialNetworkContext context) : base(context)
    {
    }
}