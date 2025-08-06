

using System.Linq.Expressions;

namespace Warehouse.Persistence.Interfaces;

public interface IRepositoryBase<T>
{
    Task<List<T>> FindAllAsync();
    Task<List<T>> FindByConditionManyAsync(Expression<Func<T, bool>> expression);
    Task<T?> FindByConditionAsync(Expression<Func<T, bool>> expression);
    Task Create(T entity);
    void Update(T entity);
    void Delete(T entity);
}
