using QuotesWebApp.Models;

namespace QuotesWebApp.Service
{
    public interface IVoteService
    {
        Task VoteAsync(int quotesId, string userId, bool IsUpVote);

        int GetVotes(int quotesId);
    }
}
