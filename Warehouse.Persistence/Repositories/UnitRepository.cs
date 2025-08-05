

using Warehouse.Persistence.Entities;
using Warehouse.Persistence.Interfaces;

namespace Warehouse.Persistence.Repositories;

public class UnitRepository : RepositoryBase<Unit>, IUnitRepository
{
    public UnitRepository(Context context) : base(context) { }
}
