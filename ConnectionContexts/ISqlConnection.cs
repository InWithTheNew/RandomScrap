using Entities;
using Microsoft.EntityFrameworkCore;

namespace ConnectionContexts
{
    public interface ISqlConnection
    {
        DbSet<Person> Persons { get; set; }

        int SaveChanges();
    }
}
