using Microsoft.EntityFrameworkCore;
using QuotesWebApp.Data;
using QuotesWebApp.Models;

namespace QuotesWebApp.Service
{
    public class AuthorService:IAuthorService
    {
        private ApplicationDbContext _db;

        public AuthorService(ApplicationDbContext db)
        {
            this._db = db;
        }

        public async void CreateAuthor(CreateAouthorViewModel inputModel)
        {
            Author a = new Author()
            {
                Name = inputModel.Name,
                Category = inputModel.Category,
                YearsFromTo = inputModel.YearsFromTo
            };

            await _db.Authors.AddAsync(a);
            _db.SaveChanges();
        }

        public  List<AllAuthorViewModel> GetAll()
        {
            List<AllAuthorViewModel> getAll =  _db.Authors.Select(a => new AllAuthorViewModel() 
            {
                Name = a.Name,
                Category = a.Category,
                YearsFromTo = a.YearsFromTo

            }).ToList();


            return getAll;
        }
    }
}
