using Entities;
using System.Configuration;

namespace ConnectionContexts
{
    public interface ISqlConnectionFactory
    {
        ISqlConnection PersonsConnection();
        
    }
}
