using BookStore.DL.Interfaces;
using BookStore.DL.MemoryDb;
using BookStore.Models.Models;

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

        public List<Book> GetAllBooksByAuthorId(int id)
        {
            var result = InMemoryDb.BookData.Where(b => b.AuthorId == id).ToList();
            return result;
        }

    }
}
