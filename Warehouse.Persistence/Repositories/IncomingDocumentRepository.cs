
using Warehouse.Persistence.Entities;
using Warehouse.Persistence.Interfaces;

namespace Warehouse.Persistence.Repositories;

public class IncomingDocumentRepository : RepositoryBase<IncomingDocument>, IIncomingDocumentRepository
{
    public IncomingDocumentRepository(Context context) : base(context) { }
}
