using Microsoft.EntityFrameworkCore;

namespace ConnectionContexts
{
    public class SqlConnection<T> : DbContext, ISqlConnection<T>
        where T : class
    {
        public readonly string _connectionString;

        public SqlConnection(string connectionString)
        {
            _connectionString = connectionString;
        }

        public DbSet<T> Entities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(_connectionString);
        }
    }
}