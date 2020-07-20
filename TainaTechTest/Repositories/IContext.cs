using System.Data.Entity;
using TainaTechTest.Models.Domain;

namespace TainaTechTest.Repositories
{
    public interface IContext
    {
        IDbSet<Person> Persons { get; set; }
    }
}