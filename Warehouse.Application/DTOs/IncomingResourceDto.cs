

using Warehouse.Persistence.Entities;

namespace Warehouse.Application.DTOs;

public class IncomingResourceDto
{
    public Guid Id { get; set; }

    public int Amount { get; set; }

    //public Guid ResourceId { get; set; }

    //public Resource Resource { get; set; }

    //public Guid UnitId { get; set; }

    //public Unit Unit { get; set; }
}
