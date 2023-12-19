using BookStore.Models.Models;

namespace BookStore.BL.Intefaces
{
    public interface IBookService
    {
        List<Book> GetAll();

        Book GetById(int id);

        void Add(Book book);

        void Remove(int id);
    }
}
