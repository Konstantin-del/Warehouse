

namespace Warehouse.Persistence.Entities;

public class IncomingResource
{
    public Guid Id { get; set; }

    public int Amount { get; set; }

    public Guid ResourceId { get; set; }

    public Resource Resource { get; set; }

    public Guid UnitId { get; set; }

    public Unit Unit { get; set; }  
}
