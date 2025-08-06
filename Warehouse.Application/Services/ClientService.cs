
using AutoMapper;
using Warehouse.Application.DTOs;
using Warehouse.Application.Interfaces;
using Warehouse.Persistence.Entities;
using Warehouse.Persistence.Interfaces;

namespace Warehouse.Application.Services
{
    public class ClientService(IRepositoryWrapper repository, IMapper mapper) : IClientService
    {
        public async Task<List<ClientDto>> GetAllAsync() 
        {
            var result = await repository.Client.FindAllAsync();
            return mapper.Map<List<ClientDto>>(result);
        }
        public async Task<List<ClientDto>> GetByConditionAsync(ClientDto entity)
        {
            var result = await repository.Client.FindByConditionAsync(client => client.Id == entity.Id);
            return mapper.Map<List<ClientDto>>(result);
        }
        public async Task<ClientDto> GetClientByIdAsync(Guid id)
        {
            var result = await repository.Client.FindByConditionAsync(client => client.Id == id);
            return mapper.Map<ClientDto>(result.FirstOrDefault());
        }
        public async Task CreateAsync(ClientDto client)
        {
            var clientEntity = mapper.Map<Client>(client);
            repository.Client.Create(clientEntity);
            await repository.SaveAsync();
        }
        public async Task UpdateAsync(ClientDto client)
        {
            var clientEntity = mapper.Map<Client>(client);
            repository.Client.Update(clientEntity);
            await repository.SaveAsync();
        }
        public async Task DeleteAsync(ClientDto client)
        {
            var clientEntity = mapper.Map<Client>(client);
            repository.Client.Delete(clientEntity);
            await repository.SaveAsync();
        }
    }
}
