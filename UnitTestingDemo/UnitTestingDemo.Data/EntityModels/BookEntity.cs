using System.Diagnostics.CodeAnalysis;
using UnitTestingDemo.Data.Interfaces;

namespace UnitTestingDemo.Data.EntityModels
{
    [ExcludeFromCodeCoverage]
    public class BookEntity : IIntId
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public virtual AuthorEntity Author { get; set; }
    }
}
