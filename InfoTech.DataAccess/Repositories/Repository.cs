using System.Linq.Expressions;
using InfoTech.DataAccess.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace InfoTech.DataAccess.Repositories
{
    public class Repository<T> : IRepository<T> where T:class
    {
        private readonly DbSet<T> _dbSet;
        private readonly IQueryable<T> _query;
        public Repository(DbContext db)
        {
            _dbSet = db.Set<T>();
            _query = _dbSet.AsQueryable();
        }

        public T? GetById(int id)
        {

            return _dbSet.Find(id);
        }

        public T? Get(Expression<Func<T, bool>> filter)
        {
            return _query.SingleOrDefault(filter);
        }

        public IEnumerable<T> GetAll()
        {
            return _query.ToList();
        }

        public IQueryable<T> Include(string filter)
        {
            return _query.Include(filter);
        }

        public void Add(T entity)
        {
            _dbSet.Add(entity);
        }

        public void Remove(T entity)
        {
            _dbSet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            _dbSet.RemoveRange(entities);
        }

        public IQueryable<T> GetAllLazyLoad(params Expression<Func<T, object>>[] children)
        {
            children.ToList().ForEach(x=>_dbSet.Include(x).Load());
            return _dbSet;
        }
    }
}
