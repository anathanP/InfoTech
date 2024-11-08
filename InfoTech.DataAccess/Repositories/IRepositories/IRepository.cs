using System.Linq.Expressions;

namespace InfoTech.DataAccess.Repositories.IRepositories
{
    public interface IRepository<T>  where T : class
    {
        T? GetById(int id);
        T? Get(Expression<Func<T, bool>> filter);

        IEnumerable<T> GetAll();
        void Add(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
        IQueryable<T> GetAllLazyLoad(params Expression<Func<T, object>>[] children);
        IQueryable<T> GetConditionalLazyLoad(Expression <Func<T, bool>> filter, params Expression<Func<T, object>>[] children);
        IQueryable<T> FindBy(params string[] include);

    }
}
