using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace QuotesWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RatingController : ControllerBase
    {
        [HttpPost]
        public async Task<ActionResult<>> AddRating() 
        {

        }
    }
}
