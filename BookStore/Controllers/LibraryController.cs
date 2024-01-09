using BookStore.BL.Intefaces;
using BookStore.BL.Services;
using BookStore.Models.Models.Request;
using BookStore.Models.Models.Response;
using BookStore.Validators;
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

        [HttpPost]
        public string GetTestEndpoint([FromBody] GetBooksByAuthorRequest request)
        {
            var validator = new GetBooksByAuthorRequestValidator();

            var result = validator.Validate(request);
            if (result.IsValid)
            {
                return "Test Pass";
            }
            return "Test Not Pass";
        }
    }
}
