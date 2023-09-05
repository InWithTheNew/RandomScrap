using Entities;

namespace ConnectionContexts
{
    public sealed class SqlConnectionFactory : ISqlConnectionFactory
    {
        // needs to be added to a class which is also IOC'd, like "ConnectionSettings" with a connectionstring property
        public readonly IConnectionSettings _connectionSettings;

        public SqlConnectionFactory(IConnectionSettings connectionSettings)
        {
            _connectionSettings = connectionSettings ?? throw new ArgumentNullException(nameof(connectionSettings));
        }

        public ISqlConnection<Person> CreatePersonsConnection()
        {
            return new SqlConnection<Person>(_connectionSettings.ConnectionString);
        }
    }
}
