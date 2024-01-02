using BookStore.BL.Intefaces;
using BookStore.Models.Models.Request;
using BookStore.Models.Models.Response;

namespace BookStore.BL.Services
{
    public class LibraryService : ILibraryService
    {
        private readonly IAuthorService _authorService;
        private readonly IBookService _bookService;

        public LibraryService(IAuthorService authorService, IBookService bookService)
        {
            _authorService = authorService;
            _bookService = bookService;
        }

        public GetBooksByAuthorResponse? GetBooksByAuthor(GetBooksByAuthorRequest request)
        {
            var books = _bookService.GetAllBooksByAuthorId(request.AuthorId);

            if (books != null && books.Count > 0)
            {
                var response = new GetBooksByAuthorResponse
                {
                    Author = _authorService.GetById(request.AuthorId),
                    Books = books.Where(b => b.RelaseDate >= request.AfterDate).ToList()
                };
            return response;
            }

            return null;
        }
    };
}
