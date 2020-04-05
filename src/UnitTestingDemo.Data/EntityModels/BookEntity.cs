using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using UnitTestingDemo.Data.Interfaces;

namespace UnitTestingDemo.Data.EntityModels
{
    [ExcludeFromCodeCoverage]
    public class BookEntity : IIntId
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public virtual AuthorEntity Author { get; set; }
    }
}
