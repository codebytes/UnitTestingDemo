using System;
using System.Collections.Generic;
using System.Text;
using UnitTestingDemo.Data.EntityModels;
using UnitTestingDemo.Domain;

namespace UnitTestingDemo.Data.Interfaces
{
    public interface IBookRepository 
        : IRepository<BookEntity>
    {
       
    }
}
