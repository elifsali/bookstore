using BookStore.Models.Models.Request;
using BookStore.Models.Models.Response;

namespace BookStore.BL.Intefaces
{
    public interface ILibraryService
    {
        GetBooksByAuthorResponse? GetBooksByAuthor(GetBooksByAuthorRequest request);
    }
}
