using Entities;

namespace ConnectionContexts
{
    public interface ISqlConnectionFactory
    {
        ISqlConnection<Person> CreatePersonsConnection();
    }
}
