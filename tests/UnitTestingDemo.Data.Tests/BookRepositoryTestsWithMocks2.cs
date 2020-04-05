using System.Collections.Generic;
using System.Linq;
using EntityFrameworkCoreMock;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using UnitTestingDemo.Data.Contexts;
using UnitTestingDemo.Data.EntityModels;

namespace UnitTestingDemo.Data.Tests
{
    [TestClass]
    public class BookRepositoryTestsWithMocks2
    {
        private BookRepository _bookRepository;
        private Mock<BookContext> _mockBookContext;
        private IQueryable<BookEntity> _books;

        [TestInitialize]
        public void TestInitialize()
        {
            _books = new List<BookEntity>
            {
                new BookEntity
                {
                    Id = 1,
                    Title = "Hamlet",
                    Author = new AuthorEntity
                    {
                        Id = 1,
                        FirstName = "William",
                        LastName = "Shakespeare"
                    }
                },
                new BookEntity
                {
                    Id = 2,
                    Title = "A Midsummer Night's Dream",
                    Author = new AuthorEntity
                    {
                        Id = 1,
                        FirstName = "William",
                        LastName = "Shakespeare"
                    }
                }
            }.AsQueryable();

            var _mockBookContext = new DbContextMock<BookContext>(new DbContextOptionsBuilder<BookContext>().Options);
            var bookDbSetMock = _mockBookContext.CreateDbSetMock(x => x.Books, _books);
            _bookRepository = new BookRepository(_mockBookContext.Object);
        }

        [TestMethod]
        public void GetAll_WithItems_returnsAll()
        {
            //arrange

            //act
            var result = _bookRepository.GetAll();

            //assert
            Assert.AreEqual(_books.Count(), result.Count);
        }
    }
}
