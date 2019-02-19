using System.Collections.Generic;
using UnitTestingDemo.Domain;

namespace UnitTestingDemo.Models
{
    public class BookListViewModel
    {
        public IEnumerable<Book> Books { get; set; }
        public IEnumerable<Author> Authors { get; set; }
    }
}
