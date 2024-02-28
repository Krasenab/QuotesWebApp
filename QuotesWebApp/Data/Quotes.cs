using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuotesWebApp.Data
{
    public class Quotes
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Sources { get; set; }

        [Required]
        public string Description { get; set; }

        [ForeignKey(nameof(Comment))]
        public int CommentId  { get; set; }
        public Comment Comment { get; set; }


    }
}
