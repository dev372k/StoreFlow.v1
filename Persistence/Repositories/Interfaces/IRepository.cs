using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories.Interfaces
{
    public interface IRepository
    {
        IEnumerable<T> Search<T>(object parameters, string query);
    }
}
