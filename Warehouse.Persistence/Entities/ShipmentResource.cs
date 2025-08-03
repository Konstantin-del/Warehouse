

namespace Warehouse.Persistence.Entities;

public class ShipmentResource
{
    public Guid Id { get; set; }

    public int Amount { get; set; }

    public Guid IdResource { get; set; }

    public Guid IdUnits { get; set; }
}
