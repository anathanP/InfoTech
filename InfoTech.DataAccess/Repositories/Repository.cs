using System.Linq.Expressions;
using InfoTech.DataAccess.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace InfoTech.DataAccess.Repositories
{
    public class Repository<T> : IRepository<T> where T:class
    {
        private readonly DbSet<T> _dbSet;
        public Repository(DbContext db)
        {
            _dbSet = db.Set<T>();
        }

        public T? GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public T? Get(Expression<Func<T, bool>> filter)
        {
            return _dbSet.SingleOrDefault(filter);
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
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
    }
}
