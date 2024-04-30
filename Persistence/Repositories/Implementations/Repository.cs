using Persistence.Repositories.Interfaces;

namespace Persistence.Repositories.Implementations
{
    public class Repository : IRepository
    {
        public Repository()
        {

        }

        public IEnumerable<T> Search<T>(object parameters, string query)
        {
            throw new NotImplementedException();
        }

    }
}
