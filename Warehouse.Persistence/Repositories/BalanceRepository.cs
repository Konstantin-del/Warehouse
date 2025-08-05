
using Warehouse.Persistence.Entities;
using Warehouse.Persistence.Interfaces;

namespace Warehouse.Persistence.Repositories;

public class BalanceRepository : RepositoryBase<Balance>, IBalanceRepository
{
    public BalanceRepository(Context context):base(context) { }
}
