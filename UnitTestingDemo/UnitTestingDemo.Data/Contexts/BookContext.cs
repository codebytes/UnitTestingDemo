using Microsoft.EntityFrameworkCore;
using UnitTestingDemo.Data.EntityModels;

namespace UnitTestingDemo.Data.Contexts
{
    public class BookContext : DbContext
    {
        public BookContext()
        { }

        public BookContext(DbContextOptions<BookContext> options)
            : base(options)
        { }

        public virtual DbSet<BookEntity> Books { get; set; }
        public virtual DbSet<AuthorEntity> Authors { get; set; }
    }
}
