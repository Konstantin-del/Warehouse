
using Warehouse.Persistence.Entities;
using Warehouse.Persistence.Interfaces;

namespace Warehouse.Persistence.Repositories;

public class ClientRepository : RepositoryBase<Client>, IClientRepository
{
    public ClientRepository(Context context) : base(context) { }
}
