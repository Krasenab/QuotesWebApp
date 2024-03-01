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

        
        public void CreateQuotes(int authorId,CreateQuotesViewModel model)
        {

            Quotes q = new Quotes()
            {
                AuthorId = authorId,
                Sources = model.Sources,
                Description = model.Description
            };

            _db.Quotes.Add(q);
            _db.SaveChanges();
            
        }
    }
}
