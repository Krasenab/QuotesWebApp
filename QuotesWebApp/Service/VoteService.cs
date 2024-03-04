
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuotesWebApp.Data;

namespace QuotesWebApp.Service
{
    public class VoteService : IVoteService
    {
        private ApplicationDbContext _Dbcontext;
        public VoteService(ApplicationDbContext applicationDbContext)
        {
                _Dbcontext = applicationDbContext;
        }

        public int GetVotes(int quotesId)
        {
           var votes = _Dbcontext.Votes.Where(x=>x.QuotesId== quotesId).Sum(x=>(int)x.VoteType);
            return votes;
        }

        public async Task VoteAsync(int quotesId, string userId, bool IsUpVote)
        {
            var vote = _Dbcontext.Votes.FirstOrDefault(x=>x.QuotesId == quotesId && x.ApplicationUserId.ToString() == userId);
            if (vote!=null)
            {
                vote.VoteType = IsUpVote ? VoteType.UpVote : VoteType.DownVote;
            }
            else
            {
                vote = new Vote
                {
                    QuotesId = quotesId,
                    ApplicationUserId = Guid.Parse(userId),
                    VoteType = IsUpVote ? VoteType.UpVote : VoteType.DownVote
                };

                await this._Dbcontext.Votes.AddAsync(vote);

            }

            await _Dbcontext.SaveChangesAsync();
        }


    }
}
