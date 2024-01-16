using BookStore.BL.Services;
using BookStore.DL.Interfaces;
using BookStore.Models.Models;
using Moq;

namespace BookStore.Test
{
    public class BookTest
    {
        public static List<Book> BookData = new List<Book>()
        {
        new Book()
        {
            Id = 1,
            Title = "Name 1",
            AuthorId = 1,
            RelaseDate = new DateTime(2012, 03, 13)
        },
        new Book()
        {
            Id= 2,
            Title = "Name 2",
            AuthorId = 2,
            RelaseDate = new DateTime(2019, 04, 18)
        },
        new Book()
        {
            Id = 3,
            Title = "Name 3",
            AuthorId = 3,
            RelaseDate = new DateTime(2014, 05, 14)
        },
        new Book()
        {
            Id = 4,
            Title = "Name 4",
            AuthorId = 1,
            RelaseDate = new DateTime(2021, 03, 13)
        },
        };
        [Fact]
        public void GetAllByAuthorId_Count_Check()
        {
            var expectedCount = 2;
            var authorId = 1;

            var mockedBookRepository = new Mock<IBookRepository>();
            mockedBookRepository.Setup(x => x.GetAllBooksByAuthorId(authorId))
                .Returns(BookData.Where(b => b.AuthorId == authorId).ToList());

            //injects
            var service = new BookService(mockedBookRepository.Object);

            //act
            var result = service.GetAllBooksByAuthorId(authorId);

            //assert
            Assert.NotNull(result);
            Assert.Equal(expectedCount, result.Count());
        }
        [Fact]
        public void GetAllByAuthorId_WrongId()
        {
            var expectedCount = 0;
            var authorId = 11;

            var mockedBookRepository = new Mock<IBookRepository>();
            mockedBookRepository.Setup(x => x.GetAllBooksByAuthorId(authorId))
                .Returns(BookData.Where(b => b.AuthorId == authorId).ToList());

            //injects
            var service = new BookService(mockedBookRepository.Object);

            //act
            var result = service.GetAllBooksByAuthorId(authorId);

            //assert
            Assert.NotNull(result);
            Assert.Equal(expectedCount, result.Count());
        }

        [Fact]
        public void TestCalculation_Result_Check()
        {
            var expectedResult = 14;
            var testNumber = 10;

            var mockedBookRepository = new Mock<IBookRepository>();
            mockedBookRepository.Setup(x => x.GetAll())
                .Returns(BookData);

            //injects
            var service = new BookService(mockedBookRepository.Object);

            //act
            var result = service.TestCalculation(testNumber);

            //assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Remove_Count_Check()
        {
            var expectedResult = 3;
            var bookId = 1;
            var bookToRemove = BookData.FirstOrDefault(x=>x.Id == bookId);

            var mockedBookRepository = new Mock<IBookRepository>();
            mockedBookRepository.Setup(x => x.Remove(bookId)).Callback(() =>
            {
                BookData.Remove(bookToRemove);
            });

            //injects
            var service = new BookService(mockedBookRepository.Object);

            //act
            service.Remove(bookId);

            //assert
            Assert.Equal(expectedResult, BookData.Count);
        }

    }
}