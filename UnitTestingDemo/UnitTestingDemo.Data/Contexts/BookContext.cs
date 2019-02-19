using Microsoft.EntityFrameworkCore;
using UnitTestingDemo.Data.EntityModels;

namespace UnitTestingDemo.Data.Contexts
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options)
            : base(options)
        { }

        public DbSet<BookEntity> Books { get; set; }
    }
}
