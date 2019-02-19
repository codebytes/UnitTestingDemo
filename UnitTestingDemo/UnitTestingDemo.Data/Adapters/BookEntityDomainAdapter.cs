using System;
using UnitTestingDemo.Data.EntityModels;
using UnitTestingDemo.Data.Interfaces;
using UnitTestingDemo.Domain;

namespace UnitTestingDemo.Data.Adapters
{
    public class BookEntityDomainAdapter : IBookEntityDomainAdapter
    {
        public Book Adapt(BookEntity bookEntity)
        {
            return new Book
            {
                Id = bookEntity.Id,
                Title = bookEntity.Title,
                Author = bookEntity.Author
            };
        }

        public BookEntity FromDomain(Book book)
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
