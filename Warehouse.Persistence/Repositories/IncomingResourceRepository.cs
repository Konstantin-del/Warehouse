

using Warehouse.Persistence.Entities;
using Warehouse.Persistence.Interfaces;

namespace Warehouse.Persistence.Repositories;

public class IncomingResourceRepository : RepositoryBase<IncomingResource>, IIncomingResourceRepository
{
    public IncomingResourceRepository(Context context) : base(context) { }
}
