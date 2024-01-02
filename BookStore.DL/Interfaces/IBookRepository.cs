using BookStore.BL;
using BookStore.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DL.Interfaces
{
    public interface IBookRepository
    {
        List<Book> GetAll();

        Book GetById(int id);

        void Add(Book book);

        void Remove(int id);
        List<Book> GetAllBooksByAuthorId(int authorId);
    }
}
