using BookStore.BL.Intefaces;
using BookStore.DL.Interfaces;
using BookStore.DL.Repositories;
using BookStore.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.BL.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public void Add(Book book)
        {
            _bookRepository.Add(book);
        }

        public List<Book> GetAll()
        {
            return _bookRepository.GetAll();
        }

        public Book GetById(int id)
        {
            return _bookRepository.GetById(id);
        }

        public void Remove(int id)
        {
            _bookRepository.Remove(id);
        }

        public List<Book>GetAllBooksByAuthorId(int authorId)
        {
            return _bookRepository.GetAllBooksByAuthorId(authorId);
        }

      
    }
}
