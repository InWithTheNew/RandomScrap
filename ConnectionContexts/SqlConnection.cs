using System;
using Microsoft.EntityFrameworkCore;

namespace ConnectionContexts
{
    public class SqlConnection<T> : DbContext, ISqlConnection
        where T : class
    {
        public DbSet<T> Person { get; set; }

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