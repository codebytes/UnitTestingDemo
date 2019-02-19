using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnitTestingDemo.Data.Interfaces;
using UnitTestingDemo.Domain;
using UnitTestingDemo.Services.Interfaces;

namespace UnitTestingDemo.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;
        private readonly IBookEntityDomainAdapter _bookEntityDomainAdapter;

        public BookService(IBookRepository bookRepository, IBookEntityDomainAdapter bookEntityDomainAdapter)
        {
            _bookRepository = bookRepository;
            _bookEntityDomainAdapter = bookEntityDomainAdapter;
        }

        public IEnumerable<Book> GetAll()
        {
            return _bookRepository.GetAll().Select(b=>_bookEntityDomainAdapter.Adapt(b));
        }
    }
}
