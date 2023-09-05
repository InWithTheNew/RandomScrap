using Microsoft.EntityFrameworkCore;

namespace ConnectionContexts
{
    public interface ISqlConnection<T>
        where T : class
    {
        DbSet<T> Entities { get; set; }
    }
}
