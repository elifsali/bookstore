using BookStore.BL.Intefaces;
using BookStore.BL.Services;
using BookStore.Models.Models.Request;
using BookStore.Models.Models.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibraryController : ControllerBase
    {
        private readonly ILibraryService _libraryService;

        public LibraryController(ILibraryService libraryService)
        {
            _libraryService = libraryService;
        }

        [HttpPost]
        public GetBooksByAuthorResponse? GetBooksByAuthor(GetBooksByAuthorRequest request)
        {
            if (request == null) return null;

            return _libraryService.GetBooksByAuthor(request);

        }
    }
}
