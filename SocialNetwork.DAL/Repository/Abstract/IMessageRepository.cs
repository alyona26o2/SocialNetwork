using SocialNetwork.Entities;

namespace SocialNetwork.Repository.Abstract;

public interface IMessageRepository : IGenericRepository<MessageEntity>
{
    IList<MessageEntity> GetChatMessages(int firstUserId, int secondUserId);

    public void Edit(int id, string text);

}