
namespace Warehouse.Persistence.Entities;

public class Client
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public string Address { get; set; }

    public string State { get; set; }

    public ShipmentDocument[]? Document { get; set; }
}
