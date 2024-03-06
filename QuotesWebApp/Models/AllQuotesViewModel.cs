using AutoMapper;
using System.Reflection.Metadata.Ecma335;

namespace QuotesWebApp.Models
{
    public class AllQuotesViewModel  
    {
        public int QuoteId { get; set; }
        public string AuthorName { get; set; }

        public string Description { get; set; }

        public string Sources { get; set; }

        public int VotesCount { get; set; } 

    
    }
}
