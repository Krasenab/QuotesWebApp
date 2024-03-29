﻿
using Microsoft.EntityFrameworkCore;
using QuotesWebApp.Data;
using QuotesWebApp.Models;

namespace QuotesWebApp.Service
{
    public class RatingService : IRatingService
    {
        private ApplicationDbContext _context;
        public RatingService(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;     
        }

        
        public async Task  AddRating(int starValue, int authorId, string applicationUserId)
        {
            var isExistRating = await _context.Ratings
                .Where(x=>x.AhtorId == authorId && x.ApplicationUserId.ToString()==applicationUserId)
                .FirstOrDefaultAsync();

            if (isExistRating != null) 
            {
                isExistRating.AhtorId = authorId;
                isExistRating.RatingValue = starValue;
            }
            else
            {
                Rating r = new Rating() 
                {
                    AhtorId = authorId,
                    ApplicationUserId = Guid.Parse(applicationUserId),
                    RatingValue = starValue
                   
                };

                await _context.Ratings.AddAsync(r);

            }
            await _context.SaveChangesAsync();  
        }
    
        public double GetRating(int ahtorId)
        {

            double countOfPeople = _context.Ratings.Where(x=>x.AhtorId==ahtorId).Count();
            //double starValue = _context.Ratings.Where(x=>x.AhtorId==ahtorId).Select(x=>x.RatingValue).First();
            double sum = _context.Ratings.Where(x => x.AhtorId == ahtorId).Sum(x => x.RatingValue);
            double result = sum/countOfPeople;
            return result;
        }
    }
}
