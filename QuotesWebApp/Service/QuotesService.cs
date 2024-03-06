using Microsoft.EntityFrameworkCore;
using QuotesWebApp.Data;
using QuotesWebApp.Models;

namespace QuotesWebApp.Service
{
    public class QuotesService : IQuotesService
    {
        private ApplicationDbContext _db;
        public QuotesService(ApplicationDbContext applicationDb)
        {
                _db = applicationDb;
        }

        public async Task<List<AllQuotesViewModel>> AllQutes(int authorId)
        {
           var getAllQuotes = await _db.Quotes.Where(x=>x.AuthorId == authorId)
                .Select(x => new AllQuotesViewModel()
                {   QuoteId = x.Id,
                    AuthorName= x.Author.Name,
                    Description= x.Description,
                    Sources= x.Sources,
                    VotesCount = x.Votes.Sum(x=>(int)x.VoteType)
                    
                }).ToListAsync();
                
                

            return getAllQuotes;
        }

        public void CreateQuotes(CreateQuotesViewModel model)
        {

            Quotes q = new Quotes()
            {
                AuthorId = model.AuthorId,
                Sources = model.Sources,
                Description = model.Description
            };

            _db.Quotes.Add(q);
            _db.SaveChanges();
            
        }

        public int GetAuthorIdForQuotes(int authorId)
        {
           int id = _db.Authors.Where(x=>x.Id == authorId).Select(x=>x.Id).FirstOrDefault();

            return id;
        }
    }
}
