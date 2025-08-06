
using AutoMapper;
using Warehouse.Application.DTOs;
using Warehouse.Presentation.ResponseModels;

namespace Warehouse.Presentation.Mappings;

public class ClientMapperProfile : Profile
{
    public ClientMapperProfile()
    {
        CreateMap<ClientResponse, ClientDto>();
    }
}
