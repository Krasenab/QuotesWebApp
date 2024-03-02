using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using QuotesWebApp.Models;

namespace QuotesWebApp.Controllers
{
    public class QuotesController : Controller
    {
        
      

        
        public IActionResult CreateQuotes(int id) 
        {

            
            return View();
        }
      
    }
}
