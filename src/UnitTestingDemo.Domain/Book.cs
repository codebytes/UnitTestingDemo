using System.Diagnostics.CodeAnalysis;

namespace UnitTestingDemo.Domain
{
    [ExcludeFromCodeCoverage]
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }
    }
}
