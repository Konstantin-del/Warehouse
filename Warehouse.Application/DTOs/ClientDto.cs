

namespace Warehouse.Application.DTOs;

public class ClientDto
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public string Address { get; set; }

    public string State { get; set; }

   // public ShipmentDocument[]? Document { get; set; }
}
