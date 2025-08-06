

namespace Warehouse.Application.DTOs;

public class IncomingDocumentDto
{
    public Guid Id { get; set; }

    public int Number { get; set; }

    public DateTimeOffset Date { get; set; }
}
