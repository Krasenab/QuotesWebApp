using System.ComponentModel.DataAnnotations;

namespace QuotesWebApp.Models
{
    public class CreateAouthorViewModel
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public string Category { get; set; }

        public string YearsFromTo { get; set; }
    }
}
