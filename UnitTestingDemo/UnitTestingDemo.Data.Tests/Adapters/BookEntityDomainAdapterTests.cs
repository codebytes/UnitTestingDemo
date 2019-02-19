using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestingDemo.Data.Adapters;
using UnitTestingDemo.Data.EntityModels;

namespace UnitTestingDemo.Data.Tests.Adapters
{
    [TestClass]
    public class BookEntityDomainAdapterTests
    {
        private BookEntityDomainAdapter _bookEntityDomainAdapter;

        [TestInitialize]
        public void TestInitialize()
        {
            _bookEntityDomainAdapter = new BookEntityDomainAdapter();
        }

        [TestMethod]
        public void Adapt_NullItem_ReturnsNull()
        {
            //Arrange
            BookEntity bookEntity = null;

            //Act
            var book = _bookEntityDomainAdapter.Adapt(bookEntity);

            //Assert
            Assert.IsNull(book);
        }

        [TestMethod]
        public void Adapt_Id_IsEqual()
        {
            //Arrange
            var bookEntity = new BookEntity
            {
                Id = 1,
                Title = "Test Title",
                Author = "Chris Ayers"

            };

            //Act
            var book = _bookEntityDomainAdapter.Adapt(bookEntity);

            //Assert
            Assert.AreEqual(bookEntity.Id, book.Id);
        }

        [TestMethod]
        public void Adapt_Title_IsEqual()
        {
            //Arrange
            var bookEntity = new BookEntity
            {
                Id = 1,
                Title = "Test Title",
                Author = "Chris Ayers"

            };

            //Act
            var book = _bookEntityDomainAdapter.Adapt(bookEntity);

            //Assert
            Assert.AreEqual(bookEntity.Title, book.Title);
        }

        [TestMethod]
        public void Adapt_Author_IsEqual()
        {
            //Arrange
            var bookEntity = new BookEntity
            {
                Id = 1,
                Title = "Test Title",
                Author = "Chris Ayers"

            };

            //Act
            var book = _bookEntityDomainAdapter.Adapt(bookEntity);

            //Assert
            Assert.AreEqual(bookEntity.Author, book.Author);
        }
    }
}
