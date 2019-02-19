using UnitTestingDemo.Data.EntityModels;
using UnitTestingDemo.Domain;

namespace UnitTestingDemo.Data.Interfaces
{
    public interface IBookEntityDomainAdapter
    {
        Book Adapt(BookEntity bookEntity);
    }
}