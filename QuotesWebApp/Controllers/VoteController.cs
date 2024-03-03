using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using QuotesWebApp.Data;
using QuotesWebApp.Models;
using QuotesWebApp.Service;

namespace QuotesWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VoteController : ControllerBase
    {
        private IVoteService voteService;
        private UserManager<ApplicationUser> userManager;
        public VoteController(IVoteService vote,UserManager<ApplicationUser> userM)
        {
            voteService = vote;
            userManager = userM;
        }
        
        //Post /api/votes/
        //Request body : {}
        //Response body:  etc.{"votesCount:16"}
        [Authorize]
        [HttpPost]        
        public async Task<ActionResult<VoteResponseModel>> QuoteVot(VoteInputViewModel model) 
        {
            var userId =  this.userManager.GetUserId(this.User);
            await this.voteService.VoteAsync(model.QuoteId, userId, model.IsUpVote);
            var votesCount = this.voteService.GetVotes(model.QuoteId);
            return new VoteResponseModel { VoteCount = votesCount };
        }
    }
}
