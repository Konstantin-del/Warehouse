

namespace Warehouse.Persistence.Entities;

public class ShipmentDocument
{
    public Guid Id { get; set; }

    public int Number { get; set; }

    public DateTime Date { get; set; }

    public string State { get; set; }

    public Guid IdClient { get; set; }
}
