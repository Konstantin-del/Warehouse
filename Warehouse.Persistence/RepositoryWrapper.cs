

using Warehouse.Persistence.Interfaces;
using Warehouse.Persistence.Repositories;

namespace Warehouse.Persistence;

public class RepositoryWrapper : IRepositoryWrapper
{
    private Context _context;

    private IBalanceRepository _balance;

    private IClientRepository _client;

    private IIncomingDocumentRepository _incomingDocument; 

    private IResourceRepository _resource;

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

    public IResourceRepository Resource
    {
        get
        {
            if( _resource == null)
            {
                _resource = new ResourceRepository(_context);
            }
            return _resource;
        }
    }

    public RepositoryWrapper(Context repositoryContext)
    {
        _context = repositoryContext;
    }

    public void Save()
    {
        _context.SaveChangesAsync();
    }
}
