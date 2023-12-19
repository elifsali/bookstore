using BookStore.BL;
using BookStore.BL.Intefaces;
using BookStore.Models.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorService _authorService;

        public AuthorController(IAuthorService authorService)
        {
            _authorService = authorService;
        }

        [HttpGet("GetAuthorById")]
        public Author GetAuthorById(int id)
        {
            return _authorService.GetById(id);
        }

        [HttpGet("GetAll")]
        public List<Author> GetAllAuthors()
        {
            return _authorService.GetAll();
        }

        [HttpPost]
        public void Add([FromBody] Author author)
        {
            _authorService.Add(author);
        }

        [HttpDelete]
        public void Delete(int id)
        {
            _authorService.Remove(id);
        }
    }
}
