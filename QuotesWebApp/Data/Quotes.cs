using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;

namespace QuotesWebApp.Data
{
    public class Quotes
    {
        public Quotes()
        {

            this.Comments = new List<Comment>();
            
            this.Votes = new List<Vote>();
        }
        [Key]
        public int Id { get; set; }

        [Required]
        public string Sources { get; set; }

        [Required]
        public string Description { get; set; }

        [ForeignKey(nameof(Author))]
        public int AuthorId  { get; set; }

        public Author Author { get; set; }


        public virtual List<Comment> Comments { get; set; }

        public virtual List<Vote> Votes  { get; set; }

    }
}
