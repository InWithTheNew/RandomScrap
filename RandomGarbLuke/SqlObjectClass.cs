using System;
using System.Reflection.Metadata;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;

namespace RandomGarbLuke
{
	public class SqlObjectClass : DbContext
	{
        public DbSet<string> FirstName { get; set; }
        public DbSet<string> LastName { get; set; }

		public string _connectionString;

        public SqlObjectClass(string configuration)
		{
            _connectionString = configuration;
		}

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sql server with connection string from app settings
            options.UseSqlServer(_connectionString);
        }


    }
}

