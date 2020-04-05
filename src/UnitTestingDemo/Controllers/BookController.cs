using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoreLinq.Extensions;
using UnitTestingDemo.Models;
using UnitTestingDemo.Services.Interfaces;

namespace UnitTestingDemo.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }
        // GET: Book
        public ActionResult Index()
        {
            var books = _bookService.GetAll();
            var authors = books.Select(x => x.Author).DistinctBy(x=>x.Id);
            return View(new BookListViewModel { Books = books, Authors = authors });
        }
    }
}