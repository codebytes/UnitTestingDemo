using System;
using System.Collections.Generic;
using System.Text;
using UnitTestingDemo.Domain;

namespace UnitTestingDemo.Services.Interfaces
{
    public interface IBookService
    {
        IEnumerable<Book> GetAll();
    }
}
