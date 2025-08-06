

namespace Warehouse.Persistence.Entities;

public class Unit
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public string State { get; set; }

    public List<Balance>? Balance { get; set; }

    public List<IncomingResource>? IncomingResource { get; set; }

    public List<ShipmentResource>? ShipmentResource { get; set; }
}
