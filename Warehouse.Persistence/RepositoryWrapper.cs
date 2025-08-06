

using Warehouse.Persistence.Entities;
using Warehouse.Persistence.Interfaces;
using Warehouse.Persistence.Repositories;

namespace Warehouse.Persistence;

public class RepositoryWrapper : IRepositoryWrapper
{
    private Context _context;

    private IBalanceRepository _balance;

    private IClientRepository _client;

    private IIncomingDocumentRepository _incomingDocument; 

    private IIncomingResourceRepository _incomingResource;

    private IResourceRepository _resource;

    private IShipmentDocumentRepository _shipmentDocument;

    private IShipmentResourceRepository _shipmentResource;

    private IUnitRepository _unit;

    public IBalanceRepository Balance
    {
        get
        {
            if (_balance == null)
            {
                _balance = new BalanceRepository(_context);
            }
            return _balance;
        }
    }

    public IClientRepository Client
    {
        get
        {
            if (_client == null)
            {
                _client = new ClientRepository(_context);
            }
            return _client;
        }
    }

    public IIncomingDocumentRepository IncomingDocument
    {
        get
        {
            if (_incomingDocument == null)
            {
                _incomingDocument = new IncomingDocumentRepository (_context);
            }
            return _incomingDocument;
        }
    }

    public IIncomingResourceRepository IncomingResource
    {
        get
        {
            if(_incomingResource == null)
            {
                _incomingResource = new IncomingResourceRepository(_context);
            }
            return _incomingResource;
        }
    }

    public IResourceRepository Resource
    {
        get
        {
            if (_resource == null)
            {
                _resource = new ResourceRepository(_context);
            }
            return _resource;
        }
    }

    public IShipmentDocumentRepository ShipmentDocument
    {
        get
        {
            if (_shipmentDocument == null)
            {
                _shipmentDocument = new ShipmentDocumentRepository(_context);
            }
            return _shipmentDocument;
        }
    }

    public IShipmentResourceRepository ShipmentResource;
    {
        get
        {
            if (_shipmentResource == null)
            {
                _shipmentResource = new ShipmentResourceRepository(_context);
            }
            return _shipmentResource;
        }
    }

    public IUnitRepository Unit
    {
        get
        {
            if (_unit == null)
            {
                _unit = new UnitRepository(_context);
            }
            return _unit;
        }
    }

    public RepositoryWrapper(Context repositoryContext)
    {
        _context = repositoryContext;
    }

    public async Task SaveAsync()
    {
        await _context.SaveChangesAsync();
    }
}
