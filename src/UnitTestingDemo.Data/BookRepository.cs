using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using UnitTestingDemo.Data.Contexts;
using UnitTestingDemo.Data.EntityModels;
using UnitTestingDemo.Data.Interfaces;

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
            return _bookContext
                .Books
                .Include(b=>b.Author)
                .ToList();
        }

        public BookEntity GetById(int id)
        {
            return _bookContext
                .Books
                .Include(b => b.Author)
                .FirstOrDefault(x => x.Id == id);
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
