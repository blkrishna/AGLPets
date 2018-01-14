using AGL.Pets.Common.Interfaces;
using AGL.Pets.Domain;
using System.Linq;

namespace AGL.Pets.UnitTests
{
    public class TestDataContext : IDataContext
    {
        public IQueryable<Person> Persons { get; set; }
    }
}
