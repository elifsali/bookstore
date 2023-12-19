using BookStore.BL;
using BookStore.DL.Interfaces;
using BookStore.DL.MemoryDb;
using BookStore.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DL.Repositories
{
    public class BookRepository : IBookRepository
    {
        public List<Book> GetAll()
        {
            return InMemoryDb.BookData;
        }
        public Book GetById(int id)
        {
            return InMemoryDb.BookData.First(a => a.Id == id);
        }
        public void Add(Book book)
        {
            InMemoryDb.BookData.Add(book);
        }
        public void Remove(int id)
        {
            var book = GetById(id);
            InMemoryDb.BookData.Remove(book);
        }
    }
}
