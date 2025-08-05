

using Warehouse.Persistence.Entities;
using Warehouse.Persistence.Interfaces;

namespace Warehouse.Persistence.Repositories;

public class ShipmentResourceRepository : RepositoryBase<ShipmentResource>, IShipmentResourceRepository
{
    public ShipmentResourceRepository(Context context) : base(context) { }
}
