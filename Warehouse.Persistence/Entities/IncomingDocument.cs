
namespace Warehouse.Persistence.Entities;

public class IncomingDocument
{
    public Guid Id { get; set; }

    public int Number { get; set; }

    public DateTimeOffset Date { get; set; }
}
