
using Warehouse.Persistence.Entities;
using Warehouse.Persistence.Interfaces;

namespace Warehouse.Persistence.Repositories;

public class ResourceRepository : RepositoryBase<Resource>, IResourceRepository
{
    public ResourceRepository(Context context) : base(context) { }
}