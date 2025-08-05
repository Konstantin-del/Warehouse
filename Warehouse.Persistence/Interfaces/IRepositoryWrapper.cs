

namespace Warehouse.Persistence.Interfaces;

public interface IRepositoryWrapper
{
    IBalanceRepository Balance {  get; }

    IClientRepository Client { get; }

    IIncomingDocumentRepository IncomingDocument { get; }

    IResourceRepository Resource { get; }

    void Save();
}
