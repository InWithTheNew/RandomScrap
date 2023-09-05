using Microsoft.Extensions.DependencyInjection;

namespace ConnectionContexts
{
    public static class Ioc
    {
        public static IServiceCollection AddSql(this IServiceCollection services)
        {
            services.AddSingleton<ISqlConnectionFactory, SqlConnectionFactory>();

            return services;
        }
    }
}
