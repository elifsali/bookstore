using BookStore.BL;
using BookStore.Models.Models;

namespace BookStore.DL.MemoryDb
{
    public static class InMemoryDb
    {
        public static List<Author> AuthorData = new List<Author>()
        {
        new Author()
        {
            Id = 1,
            Name = "Name 1",
            BirthDay = DateTime.Now,
        },
        new Author()
        {
            Id= 2,
            Name = "Name 2", 
            BirthDay = DateTime.Now,
        },
        new Author()
        {
            Id = 3,
            Name = "Name 3",
            BirthDay = DateTime.Now,
        }
        };

        public static List<Book> BookData = new List<Book>()
        {
        new Book()
        {
            Id = 1,
            Title = "Name 1",
            AuthorId = 1,
        },
        new Book()
        {
            Id= 2,
            Title = "Name 2",
            AuthorId = 2,
        },
        new Book()
        {
            Id = 3,
            Title = "Name 3",
            AuthorId = 3,
        }
        };
    }
}
