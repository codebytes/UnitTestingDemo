using UnitTestingDemo.Data.EntityModels;
using UnitTestingDemo.Domain;

namespace UnitTestingDemo.Data.Interfaces
{
    public interface IBookDomainEntityAdapter
    {
        BookEntity Adapt(Book book);
    }
}