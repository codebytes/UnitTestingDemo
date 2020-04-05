using System.Collections.Generic;

namespace UnitTestingDemo.Data.Interfaces
{
    public interface IRepository<T> 
        where T : IIntId
    {
        IList<T> GetAll();
        T GetById(int id);
        void Save(T saveThis);
        void Delete(T deleteThis);
    }
}