
using Warehouse.Application.DTOs;


namespace Warehouse.Application.Interfaces;

public interface IClientService
{
    Task<List<ClientDto>> GetAllAsync();
    Task<List<ClientDto>> GetByConditionManyAsync(ClientDto entity);
    Task<ClientDto> GetClientByIdAsync(Guid id);
    Task CreateAsync(ClientDto entity);
    Task UpdateAsync(Guid id);
    Task DeleteAsync(Guid id);
}
