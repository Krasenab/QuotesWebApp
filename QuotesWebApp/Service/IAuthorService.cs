using QuotesWebApp.Models;

namespace QuotesWebApp.Service
{
    public interface IAuthorService
    {
         void CreateAuthor(CreateAouthorViewModel inputModel);

        List<AllAuthorViewModel> GetAll();
    }
}
