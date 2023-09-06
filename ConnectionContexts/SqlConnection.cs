using Entities;
using Microsoft.EntityFrameworkCore;

namespace ConnectionContexts
{
    internal sealed class SqlConnection : DbContext, ISqlConnection
    {
        public readonly string _connectionString;

        public SqlConnection(string connectionString)
        {
            _connectionString = connectionString;
        }

        public DbSet<Person> Persons { get; set; }

        public override int SaveChanges()
        { 
            return base.SaveChanges(true);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(_connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().HasKey(x => x.Id);

            base.OnModelCreating(modelBuilder);
        }
    }
}