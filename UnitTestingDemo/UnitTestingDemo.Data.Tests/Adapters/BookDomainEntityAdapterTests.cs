using System.Diagnostics.CodeAnalysis;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestingDemo.Data.Adapters;
using UnitTestingDemo.Domain;

namespace UnitTestingDemo.Data.Tests.Adapters
{
    [ExcludeFromCodeCoverage]
    [TestClass]
    public class BookDomainEntityAdapterTests
    {
        private BookDomainEntityAdapter _bookDomainEntityAdapter;

        [TestInitialize]
        public void TestInitialize()
        {
            _bookDomainEntityAdapter = new BookDomainEntityAdapter();
        }

        [TestMethod]
        public void Adapt_NullItem_ReturnsNull()
        {
            //Arrange
            Book book = null;

            //Act
            var bookEntity = _bookDomainEntityAdapter.Adapt(book);

            //Assert
            Assert.IsNull(bookEntity);
        }

        [TestMethod]
        public void Adapt_Id_IsEqual()
        {
            //Arrange
            var book = new Book
            {
                Id = 1,
                Title = "Test Title",
            };

            //Act
            var bookEntity = _bookDomainEntityAdapter.Adapt(book);

            //Assert
            Assert.AreEqual(book.Id, bookEntity.Id);
        }

        [TestMethod]
        public void Adapt_Title_IsEqual()
        {
            //Arrange
            var book = new Book
            {
                Id = 1,
                Title = "Test Title"
            };

            //Act
            var bookEntity = _bookDomainEntityAdapter.Adapt(book);

            //Assert
            Assert.AreEqual(book.Title, bookEntity.Title);
        }

        [TestMethod]
        public void Adapt_AuthorId_IsEqual()
        {
            //Arrange
            var author= new Author{Id = 1, FirstName = "Chris", LastName = "Ayers"};
            var book= new Book
            {
                Id = 1,
                Title = "Test Title",
                AuthorId = 1,
                Author =  author
            };

            //Act
            var bookEntity = _bookDomainEntityAdapter.Adapt(book);

            //Assert
            Assert.AreEqual(book.AuthorId, bookEntity.AuthorId);
        }

        [TestMethod]
        public void Adapt_AuthorName_IsEqual()
        {
            //Arrange
            var author = new Author { Id = 1, FirstName = "Chris", LastName = "Ayers" };
            var book = new Book
            {
                Id = 1,
                Title = "Test Title",
                AuthorId = 1,
                Author = author
            };

            //Act
            var bookEntity = _bookDomainEntityAdapter.Adapt(book);

            //Assert
            Assert.AreEqual(book.Author.FirstName, bookEntity.Author.FirstName);
            Assert.AreEqual(book.Author.LastName, bookEntity.Author.LastName);
        }
    }
}
