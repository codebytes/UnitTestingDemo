using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using UnitTestingDemo.Data.EntityModels;
using UnitTestingDemo.Data.Interfaces;
using UnitTestingDemo.Domain;

namespace UnitTestingDemo.Services.Tests
{
    [TestClass]
    public class BookServiceTests
    {
        private BookService _bookService;
        private Mock<IBookRepository> _mockBookRepository;
        private Mock<IBookEntityDomainAdapter> _mockBookEntityDomainAdapter;

        [TestInitialize]
        public void TestInitialize()
        {
            _mockBookRepository = new Mock<IBookRepository>();
            _mockBookEntityDomainAdapter = new Mock<IBookEntityDomainAdapter>();

            _bookService = new BookService(_mockBookRepository.Object, _mockBookEntityDomainAdapter.Object);
        }

        [TestMethod]
        public void GetAll_ItemsInRepository_ReturnsSameNumberOfItems()
        {
            //arrange
            var sampleData = Enumerable
                .Repeat(new BookEntity(), 5)
                .ToList();
            _mockBookRepository.Setup(x => x.GetAll())
                .Returns(sampleData);

            //act
            var result = _bookService.GetAll();

            //assert
            Assert.AreEqual(sampleData.Count(), result.Count());
        }

        [TestMethod]
        public void GetAll_ItemsInRepository_CallsAdapterSameNumberOfTimes()
        {
            //arrange
            var sampleData = Enumerable
                .Repeat(new BookEntity(), 5)
                .ToList();
            _mockBookRepository.Setup(x => x.GetAll())
                .Returns(sampleData);
            _mockBookEntityDomainAdapter.Setup(x => x.Adapt(It.IsAny<BookEntity>()))
                .Returns(new Book());

            //act
            var result = _bookService.GetAll();
            //materialize list
            result.ToList();
            
            //assert
            _mockBookEntityDomainAdapter.Verify(x=>x.Adapt(It.IsAny<BookEntity>()),
                Times.Exactly(sampleData.Count));
        }
    }
}
