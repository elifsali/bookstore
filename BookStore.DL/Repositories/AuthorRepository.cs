using BookStore.BL;
using BookStore.DL.Interfaces;
using BookStore.DL.MemoryDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DL.NewFolder
{
    public class AuthorRepository : IAuthorRepository
    {
        public List<Author> GetAll()
        {
            return InMemoryDb.AuthorData;
        }
        public Author GetById(int id)
        {
            return InMemoryDb.AuthorData.First(a => a.Id == id);
        }
        public void Add(Author author)
        {
            InMemoryDb.AuthorData.Add(author);
        }
        public void Remove(int id)
        {
            var author = GetById(id);
            InMemoryDb.AuthorData.Remove(author);
        }

    }
}
