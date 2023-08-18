using System;
using Microsoft.Extensions.DependencyInjection;

namespace RandomGarbLuke;

class Program
{
    static void Main(string[] args)
    {
        var Luke = new Boy();
        var Adam = new Boy();

        var LukesShoes = Luke.GetShoes();

        IGetHeight HeightGetter = new Boy();
        HeightGetter.GetHeightinCM();
        HeightGetter.ReturnHeightAsInt();

        //// static class calls
        //Shoes.GetShoes();
        //Shoes.AddShoes(1, 2);

        //var Megan = new Girl();
        //Megan.GetShoes();

        var PersonStuff = HeightGatherer();
        var Height = PersonStuff.GetRequiredService<IGetHeight>();
        //Console.WriteLine(Height);
        var ClassHeight = PersonStuff.GetRequiredService<IGetClassHeight>();
    }
    public static IServiceProvider HeightGatherer()
    {
        IServiceCollection x = new ServiceCollection();

        x.AddSingleton<IGetHeight, Boy>();
        x.AddSingleton<IGetClassHeight, Classroom>();

        return x.BuildServiceProvider();
    }

}

