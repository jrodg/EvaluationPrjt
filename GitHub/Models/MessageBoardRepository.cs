using System.Linq;

namespace GitHub.Models
{
    public class MessageBoardRepository : IMessageBoardRepo
    {
        private ApplicationDbContext _actx;

        public MessageBoardRepository(ApplicationDbContext actx)
        {
            _actx = actx;
        }
        public IQueryable<Reply> GetRepliesBytopic(int topicId)
        {
            return _actx.Replies.Where(r => r.TopicId == topicId);
        }

        public IQueryable<Topic> GetTopics()
        {
            return _actx.Topics;
        }
    }
}