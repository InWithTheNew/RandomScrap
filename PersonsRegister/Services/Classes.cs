using ClassLibrary;
using Microsoft.EntityFrameworkCore.SqlServer.Storage.Internal;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ConnectionContexts;
using System;

namespace PersonsRegister.Services
{
    public class Classes
    {
        public static IServiceProvider ClassesProvider()
        {
            IServiceCollection x = new ServiceCollection();

            x.AddSingleton<IPerson, Person>();
            x.AddSingleton<IClass, Class>();
            x.AddSingleton<ISqlServerConnection, SqlConnection>();
            return x.BuildServiceProvider();
        }

        public Classes()
        {
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            //var Person1 = ClassesProvider().GetRequiredService(IPerson);

            // Create new class with _connectionString
            var Class1 = ClassesProvider().GetRequiredService<IClass>();
            Class1.AddStudentToClass();


        }

    }
}
