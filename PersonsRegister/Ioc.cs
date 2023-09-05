using ConnectionContexts;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace PersonsRegister
{
    public static class Ioc
    {
        public static void AddServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddSingleton<IConnectionSettings>(new ConnectionSettings(config.GetValue<string>("ConnectionStrings:SqlServer")));
            services.AddSql();
        }
    }
}
