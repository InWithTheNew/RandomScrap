using Entities;

namespace ConnectionContexts
{
    internal sealed class SqlConnectionFactory : ISqlConnectionFactory
    {
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
