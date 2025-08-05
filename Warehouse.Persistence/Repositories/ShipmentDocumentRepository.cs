

using Warehouse.Persistence.Entities;
using Warehouse.Persistence.Interfaces;

namespace Warehouse.Persistence.Repositories;

public class ShipmentDocumentRepository : RepositoryBase<ShipmentDocument>, IShipmentDocumentRepository
{
    public ShipmentDocumentRepository(Context context) : base(context) { }
}
