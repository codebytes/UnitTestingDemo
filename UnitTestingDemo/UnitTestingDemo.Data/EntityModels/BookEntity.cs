using UnitTestingDemo.Data.Interfaces;

namespace UnitTestingDemo.Data.EntityModels
{
    public class BookEntity : IIntId
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
    }
}
