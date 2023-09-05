using Entities;
using Microsoft.EntityFrameworkCore.SqlServer.Storage.Internal;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ConnectionContexts;
using System;

namespace PersonsRegister.Services
{
    public class Classes
    {
        /*
        // what are we doing / what do we want to happen:
        // 
        // we have a db with 2 tables: Person and Class. We have "entities"/"models"/classes that represent these tables *in code*.
        // we want a Factory pattern using an IOC container to allow us to talk to the db using EF.
        // 
        // how can we do this:
        // create a SqlFactory and use this in IOC. This factory will let us "new up" sql "managers"/"services" foreach of the db tables. We could try to use generics for this.
        // IOC: we don't want to register our db entities to IOC, because they're runtime logic. 
        */

        public static IServiceProvider ClassesProvider()
        {
            IServiceCollection x = new ServiceCollection();

            x.AddSingleton<IConnectionSettings>(new ConnectionSettings("myconnectionstring"));
            x.AddSql();

            return x.BuildServiceProvider();
        }

        public Classes()
        {
            
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            //var Person1 = ClassesProvider().GetRequiredService(IPerson);

            // Create new class with _connectionString
            var class1 = ClassesProvider().GetRequiredService<IClass>();
            class1.AddStudentToClass(null);
        }
    }
}
