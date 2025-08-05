
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Warehouse.Persistence.Interfaces;

namespace Warehouse.Persistence.Repositories
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected Context RepositoryContext { get; set; }
        public RepositoryBase(Context repositoryContext)
        {
            RepositoryContext = repositoryContext;
        }
        public async Task<IEnumerable<T>> FindAllAsync() => await RepositoryContext.Set<T>().AsNoTracking().ToListAsync();
        public async Task<IEnumerable<T>> FindByConditionAsync(Expression<Func<T, bool>> expression) =>
            await RepositoryContext.Set<T>().Where(expression).AsNoTracking().ToListAsync();
        public void Create(T entity) => RepositoryContext.Set<T>().Add(entity);
        public void Update(T entity) => RepositoryContext.Set<T>().Update(entity);
        public void Delete(T entity) => RepositoryContext.Set<T>().Remove(entity);
    }
}
