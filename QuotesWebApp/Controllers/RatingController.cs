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
    public class RatingController : ControllerBase
    {
        private RatingService ratingService;
        private UserManager<ApplicationUser> uManager;
        public RatingController(UserManager<ApplicationUser> userManager,RatingService rating)
        {
                uManager = userManager;
            ratingService = rating;
        }
        [HttpPost]
        public async Task<ActionResult<RatingResponseViewModel>> AddRating(RatingInputViewModel ratingInputViewModel)
        {
            int idAuhtor = ratingInputViewModel.AuthorId;
            int starRating = ratingInputViewModel.StarValue;

            var currentUser = this.uManager.GetUserId(this.User);
            await ratingService.AddRating(ratingInputViewModel.StarValue, ratingInputViewModel.AuthorId, currentUser);
            var ratingResult = this.ratingService.GetRating(ratingInputViewModel.AuthorId);

            return new RatingResponseViewModel { RatingResult = ratingResult };
        }
    }
}
