using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionContexts
{
    
    public interface IConnectionSettings
    {
        public string ConnectionString { get; }
    }
}
