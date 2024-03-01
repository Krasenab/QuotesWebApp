using QuotesWebApp.Models;

namespace QuotesWebApp.Service
{
    public interface  IQuotesService
    {
        void CreateQuotes(int authorId,CreateQuotesViewModel viewModel);

    }
}
