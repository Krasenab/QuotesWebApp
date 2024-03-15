using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuotesWebApp.Data
{
    public class Author
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public string Category { get; set; }
        public string YearsFromTo { get; set; }

        [ForeignKey(nameof(Quotes))]
        public int? QuotesId { get; set; }
        public Quotes? Quotes { get; set; }

        
    }
}
