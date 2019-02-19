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
            return book == null 
                ? null 
                : new BookEntity
                    {
                        Id = book.Id,
                        Title = book.Title,
                        AuthorId = book.AuthorId,
                        Author = AdaptAuthor(book.Author)
                };
        }

        private AuthorEntity AdaptAuthor(Author bookAuthor)
        {
            return bookAuthor == null
                ? null
                : new AuthorEntity
                {
                    Id = bookAuthor.Id,
                    FirstName = bookAuthor.FirstName,
                    LastName = bookAuthor.LastName
                };
        }
    }
}
