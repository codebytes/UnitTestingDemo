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
            return bookEntity == null
                ? null
                : new Book
                    {
                        Id = bookEntity.Id,
                        Title = bookEntity.Title,
                        Author = bookEntity.Author
                    };
        }
    }
}
