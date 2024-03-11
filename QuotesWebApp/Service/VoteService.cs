
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuotesWebApp.Data;
using QuotesWebApp.Models;

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
            var existUser = userId;
            var userGuid = Guid.Parse(userId);
            var vote = _Dbcontext.Votes.FirstOrDefault(x => x.QuotesId == quotesId && x.ApplicationUserId == userGuid);

            if (vote!=null)
            {
                              
                    vote.VoteType = IsUpVote ? VoteType.UpVote : VoteType.DownVote;                                  
            }
            else
            {
                vote = new Vote
                {
                    QuotesId = quotesId,
                    ApplicationUserId = userGuid,
                    VoteType = IsUpVote ? VoteType.UpVote : VoteType.DownVote
                };

                this._Dbcontext.Votes.Add(vote);

            }

            await _Dbcontext.SaveChangesAsync();
        }


    }
}
