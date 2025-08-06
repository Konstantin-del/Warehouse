

namespace Warehouse.Persistence.Interfaces;

public interface IRepositoryWrapper
{
    IBalanceRepository Balance { get; }

    IClientRepository Client { get; }

    IIncomingDocumentRepository IncomingDocument { get; }

    IIncomingResourceRepository IncomingResource { get; }

    IResourceRepository Resource { get; }

    IShipmentDocumentRepository ShipmentDocument { get; }

    IShipmentResourceRepository ShipmentResource { get; }

    IUnitRepository Unit { get; }

    Task SaveAsync();
}
