using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace QuotesWebApp.Controllers
{
    public class QuotesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CreateQuotes() 
        {
            return View();
        }
      
    }
}
