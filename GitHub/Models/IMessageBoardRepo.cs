using System.Linq;

namespace GitHub.Models
{
    public interface IMessageBoardRepo
    {
        IQueryable<Topic> GetTopics();
        IQueryable<Reply> GetRepliesBytopic(int topicId);
    }
}
