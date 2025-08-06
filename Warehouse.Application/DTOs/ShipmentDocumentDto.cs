

namespace Warehouse.Application.DTOs;

public class ShipmentDocumentDto
{
    public Guid Id { get; set; }

    public int Number { get; set; }

    public DateTimeOffset Date { get; set; }

    public string State { get; set; }

    //public Guid ClientId { get; set; }

    //public Client Client { get; set; }
}
