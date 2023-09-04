using System;
using Microsoft.EntityFrameworkCore;

namespace ConnectionContexts
{
    public class SqlConnection<T> : DbContext
    {
        public DbSet<Person> Person { get; set; }

        public string _connectionString;

        public SqlConnection(string configuration)
        {
            _connectionString = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer();
        }
    }
}