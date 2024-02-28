using System.ComponentModel.DataAnnotations;

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
    }
}
