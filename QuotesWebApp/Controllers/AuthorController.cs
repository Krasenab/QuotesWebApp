using Microsoft.AspNetCore.Mvc;
using QuotesWebApp.Models;
using QuotesWebApp.Service;

namespace QuotesWebApp.Controllers
{
    public class AuthorController : Controller
    {
        private IAuthorService _authorService;

        public AuthorController(AuthorService authorService)
        {
                this._authorService = authorService;
            
        }
        [HttpGet]
        public IActionResult Create()
        {
            CreateAouthorViewModel viewModel = new CreateAouthorViewModel();
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Create(CreateAouthorViewModel viewModel) 
        {
            _authorService.CreateAuthor(viewModel);
            return RedirectToAction("All", "Author");
        }


        [HttpGet]
        public  IActionResult All() 
        {
          
            
            var getAll = _authorService.GetAll();
            return View(getAll);
        }
    }
}
