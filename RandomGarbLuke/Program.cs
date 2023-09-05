using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using System.Collections.Generic;

namespace RandomGarbLuke;

class Program
{
    static void Main(string[] args)
    {

        var listthingy = new List<IGetHeight>()
        {
            new Boy(150),
            new Girl(120)
        };

        listthingy.ForEach(x => { Console.WriteLine(x.GetHeightinCM().ToString()); });

        //IGetHeight x = new Boy("Bob", "Marley");

        //x.ReturnHeightAsInt();

        //var configuration = new ConfigurationBuilder()
        //    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

        //IConfiguration config = configuration.Build();

        //var randomVar = config.GetRequiredSection("ConnectionString:SqlServer");
    }
    //public static IServiceProvider HeightGatherer(string FirstName, string LastName)
    //{
    //    IServiceCollection x = new ServiceCollection();

    //    x.AddSingleton<IGetHeight, Boy>();
    //    x.AddSingleton<IGetClassHeight, Classroom>();

    //    return x.BuildServiceProvider();
    //}
    

}