using System;
using Microsoft.Extensions.DependencyInjection;

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

        IWriteHeight Another = new Boy();
        Another.WriteClass();
        //// static class calls
        //Shoes.GetShoes();
        //Shoes.AddShoes(1, 2);

        ////var Megan = new Girl();
        ////Megan.GetShoes();

        var PersonStuff = HeightGatherer(FirstName: "Luke", LastName: "Lucas");
        var Height = PersonStuff.GetRequiredService<IGetHeight>();
        //Console.WriteLine(Height);
        var ClassHeight = PersonStuff.GetRequiredService<IGetClassHeight>();

        //var s = new SqlObject("Server=tcp:sqlserverforadamlol.database.windows.net,1433;" +
        //    "Initial Catalog=sqldatabaseforadamlol;Persist Security Info=False;" +
        //    "User ID=sqlserverforadamlol;Password=Password1;MultipleActiveResultSets=False;" +
        //    "Encrypt=True;TrustServerCertificate=True;Connection Timeout=30;");

        //var t = s.GetResults();

        //s.AddResults("Lee", "Grix", 180, "dbo.Persons");

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

