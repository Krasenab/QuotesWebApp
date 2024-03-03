using System.ComponentModel.DataAnnotations.Schema;

namespace QuotesWebApp.Data
{
    public class Vote
    {
        public int Id{ get; set; }

        [ForeignKey(nameof(ApplicationUser))]
        public Guid? ApplicationUserId { get; set; }

        public ApplicationUser? ApplicationUser { get; set; }

        [ForeignKey(nameof(Quotes))]
        public int QuotesId { get; set; }

        public Quotes Quotes { get; set; }

        public VoteType VoteType { get; set; }
    }
}
