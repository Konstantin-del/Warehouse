using Warehouse.Application.Interfaces;
using Warehouse.Persistence;
using Warehouse.Persistence.Entities;
using Warehouse.Persistence.Interfaces;

namespace Warehouse.Application.Services
{
    public class ResourceService(IRepositoryWrapper repository) : IResourceService
    {
        public void AddResource(Resource resource)
        {

            repository.Resource.Create(resource);
            repository.Save();
        }
    }
}
