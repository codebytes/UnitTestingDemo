using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using UnitTestingDemo.Controllers;
using UnitTestingDemo.Domain;
using UnitTestingDemo.Models;
using UnitTestingDemo.Services.Interfaces;

namespace UnitTestingDemo.Tests.Controllers
{
    [ExcludeFromCodeCoverage]
    [TestClass]
    public class BookControllerTests
    {
        private BookController _bookController;
        private Mock<IBookService> _mockBookService;

        [TestInitialize]
        public void TestInitialize()
        {
            _mockBookService = new Mock<IBookService>();
            _bookController = new BookController(_mockBookService.Object);
        }

        [TestMethod]
        public void Constructor_valid_ReturnsNotNull()
        {
            //arrange
            //act
            //assert
            Assert.IsNotNull(_bookController);
        }

        [TestMethod]
        public void Index_Returns_Model()
        {
            //arrange
            var bookList = new List<Book>
            {
                new Book{Id = 1, Title = "Testing", AuthorId = 1}
            };
            _mockBookService.Setup(x => x.GetAll())
                .Returns(bookList);

            //act
            var response = _bookController.Index() as ViewResult;

            //assert
            Assert.IsNotNull(response.Model);
            Assert.IsInstanceOfType(response.Model, typeof(BookListViewModel));
        }

        [TestMethod]
        public void Index_calls_BookService()
        {
            //arrange
            var bookList = new List<Book>
            {
                new Book{Id = 1, Title = "Testing", AuthorId = 1}
            };
            _mockBookService.Setup(x => x.GetAll())
                .Returns(bookList);

            //act
            var response = _bookController.Index() as ViewResult;

            //assert
            _mockBookService.Verify(x=>x.GetAll(), Times.Once);
        }
    }
}
