using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using UnitTestingDemo.Data.Interfaces;

namespace UnitTestingDemo.Data.EntityModels
{
    [ExcludeFromCodeCoverage]
    public class AuthorEntity : IIntId
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual IList<BookEntity> Books { get; set; } = new List<BookEntity>();
    }
}