using DAL.Repositories.Interfaces;

namespace DAL.Repositories.Implementations
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        public Repository()
        {

        }

        public IEnumerable<TEntity> Search(object parameters, string query)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Model> Search<Model>(object parameters, string query)
        {
            throw new NotImplementedException();
        }
    }
}
