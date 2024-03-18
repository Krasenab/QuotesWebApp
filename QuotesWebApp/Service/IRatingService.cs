using QuotesWebApp.Models;

namespace QuotesWebApp.Service
{
    public interface IRatingService
    {
        Task AddRating(int starValue,int authorId,string applicationUserId);

        double GetRating(int AhtorId);

        List<RatingInputViewModel> GetAllAuhstorsRatings();
    }
}
