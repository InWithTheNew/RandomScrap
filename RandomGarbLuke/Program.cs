using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;

namespace RandomGarbLuke;

class Program
{
    static void Main(string[] args)
    {
        //var Luke = new Boy();
        //var x = Luke._height;
        //var Adam = new Boy();

        //var LukesShoes = Luke.GetShoes();

        //IGetHeight HeightGetter = new Boy();
        //HeightGetter.GetHeightinCM();
        //HeightGetter.ReturnHeightAsInt();

        //IWriteHeight Another = new Boy();
        //Another.WriteClass();
        //// static class calls
        //Shoes.GetShoes();
        //Shoes.AddShoes(1, 2);

        ////var Megan = new Girl();
        ////Megan.GetShoes();

        //var PersonStuff = HeightGatherer(FirstName: "Luke", LastName: "Lucas");
        //var Height = PersonStuff.GetRequiredService<IGetHeight>();
        ////Console.WriteLine(Height);
        //var ClassHeight = PersonStuff.GetRequiredService<IGetClassHeight>();

        //var t = s.GetResults();

        //s.AddResults("Lee", "Grix", 180, "dbo.Persons");
        var configuration = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json",optional: false, reloadOnChange: true);

        IConfiguration config = configuration.Build();

        //var y = config.GetRequiredSection("Database:ConnectionString").Value;

        var dbConnection = new SqlObjectClass(config.GetConnectionString("SqlServer").ToString());


        //db.Add(new Boy("Jimmy", "McGill"));

        Console.ReadKey();
    }

    public static IServiceProvider HeightGatherer(string FirstName, string LastName)
    {
        IServiceCollection x = new ServiceCollection();

        x.AddSingleton<IGetHeight, Boy>();
        x.AddSingleton<IGetClassHeight, Classroom>();

        return x.BuildServiceProvider();
    }

}

