using System.ComponentModel.DataAnnotations;

namespace QuotesWebApp.Models
{
    public class CreateQuotesViewModel
    {
        [Required]
        public string Sources { get; set; }

        [Required]
        public string Description { get; set; }

        
    }

}
