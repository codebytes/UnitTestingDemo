using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using UnitTestingDemo.Data.Contexts;
using UnitTestingDemo.Data.EntityModels;

namespace UnitTestingDemo.Data.Tests
{
    [TestClass]
    public class BookRepositoryTestsWithMocks
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

            var mockSet = new Mock<DbSet<BookEntity>>();
            mockSet.As<IQueryable<BookEntity>>().Setup(m => m.Provider)
                .Returns(_books.Provider);
            mockSet.As<IQueryable<BookEntity>>().Setup(m => m.Expression)
                .Returns(_books.Expression);
            mockSet.As<IQueryable<BookEntity>>().Setup(m => m.ElementType)
                .Returns(_books.ElementType);
            mockSet.As<IQueryable<BookEntity>>().Setup(m => m.GetEnumerator())
                .Returns(_books.GetEnumerator());

            _mockBookContext = new Mock<BookContext>();
            _mockBookContext.Setup(c => c.Books)
                .Returns(mockSet.Object);

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
