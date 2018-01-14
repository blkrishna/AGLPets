using AGL.Pets.Domain;
using System.Linq;

namespace AGL.Pets.Common.Interfaces
{
    /// <summary>
    /// DataContext interfact
    /// </summary>
    public interface IDataContext
    {
        IQueryable<Person> Persons { get; set; }
    }
}
