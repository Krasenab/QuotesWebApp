using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using QuotesWebApp.Data;
using QuotesWebApp.Models;
using QuotesWebApp.Service;

namespace QuotesWebApp.Controllers
{
    public class QuotesController : Controller
    {
        private ApplicationDbContext _db;
        private QuotesService _quotesService;
        public QuotesController(ApplicationDbContext applicationDb,QuotesService service)
        {
            this._db = applicationDb;
            _quotesService = service;
        }


        [HttpGet]
        public IActionResult CreateQuotes(int authorId)
        {

            var author = _db.Authors.Where(x => x.Id == authorId).Select(x => new CreateQuotesViewModel()
            {
                AuthorId = authorId
            }).FirstOrDefault();

            int id = _quotesService.GetAuthorIdForQuotes(authorId);

            CreateQuotesViewModel model = new CreateQuotesViewModel()
            {
               AuthorId= id
            };



            return View(model);
        }
        
        public IActionResult CreateQuotes(CreateQuotesViewModel model)
        {
           
            _quotesService.CreateQuotes(model);

            return RedirectToAction("Index","Home");
        }
    }
}
