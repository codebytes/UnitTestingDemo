using System;
using UnitTestingDemo.Data.EntityModels;
using UnitTestingDemo.Data.Interfaces;
using UnitTestingDemo.Domain;

namespace UnitTestingDemo.Data.Adapters
{
    public class BookDomainEntityAdapter : IBookDomainEntityAdapter
    {
        public BookEntity Adapt(Book book)
        {
            return new BookEntity
            {
                Id = book.Id,
                Title = book.Title,
                Author = book.Title
            };
        }
    }
}
