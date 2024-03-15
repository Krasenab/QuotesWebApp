using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;

namespace QuotesWebApp.Data
{
    public class Rating
    {
        [Key]
        public int Id { get; set; }
        
        public int RatingValue { get; set; }

        [ForeignKey(nameof(ApplicationUser))]
        public Guid ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        [ForeignKey(nameof(Author))]
        public int AhtorId { get; set; }
        public Author Author { get; set; }
    }
}
