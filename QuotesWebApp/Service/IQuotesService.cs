using QuotesWebApp.Models;

namespace QuotesWebApp.Service
{
    public interface  IQuotesService
    {
        void CreateQuotes(CreateQuotesViewModel viewModel);

        int GetAuthorIdForQuotes (int authorId);

        Task<List<AllQuotesViewModel>> AllQutes(int authorId);     

    }
}
