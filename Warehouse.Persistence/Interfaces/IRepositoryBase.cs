

using System.Linq.Expressions;

namespace Warehouse.Persistence.Interfaces;

public interface IRepositoryBase<T>
{
    Task<IEnumerable<T>> FindAllAsync();
    Task<IEnumerable<T>> FindByConditionAsync(Expression<Func<T, bool>> expression);
    void Create(T entity);
    void Update(T entity);
    void Delete(T entity);
}
