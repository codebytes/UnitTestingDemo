using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnitTestingDemo.Data.Contexts;
using UnitTestingDemo.Data.EntityModels;
using UnitTestingDemo.Data.Interfaces;
using UnitTestingDemo.Domain;

namespace UnitTestingDemo.Data
{
    public class BookRepository : IBookRepository
    {
        private readonly BookContext _bookContext;

        public BookRepository(BookContext bookContext)
        {
            _bookContext = bookContext;
        }

        public IList<BookEntity> GetAll()
        {
            return _bookContext.Books.ToList();
        }

        public BookEntity GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Save(BookEntity saveThis)
        {
            throw new NotImplementedException();
        }

        public void Delete(BookEntity deleteThis)
        {
            throw new NotImplementedException();
        }
    }
}
