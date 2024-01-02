using BookStore.BL.Intefaces;
using BookStore.Models.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace BookStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet("GetBookById")]
        public Book GetBookById(int id)
        {
            return _bookService.GetById(id);
        }

        [HttpGet("GetAll")]
        public List<Book> GetAllBooks()
        {
            return _bookService.GetAll();
        }

        [HttpPost("Add")]
        public void Add([FromBody] Book book) 
        {
            if (book == null) return; 
            _bookService.Add(book);
            
        }

        [HttpDelete]
        public void Delete(int id)
        {
            _bookService.Remove(id);
        }
    }
}
