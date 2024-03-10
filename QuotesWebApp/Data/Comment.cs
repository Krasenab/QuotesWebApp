using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuotesWebApp.Data
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(500)] //like old times 
        public string Content { get; set; }


        [ForeignKey(nameof(ApplicationUser))]
        public Guid ApplicationUserId { get; set; }

        public ApplicationUser ApplicationUser { get; set; }

        [ForeignKey(nameof(Quotes))]
        public int QuotesId { get; set; }

        public Quotes Quotes { get; set; }
    }
}
