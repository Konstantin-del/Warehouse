

using AutoMapper;
using Warehouse.Application.DTOs;
using Warehouse.Persistence.Entities;

namespace Warehouse.Application.Mappings;

public class ClientDtoMapperProfile : Profile
{
    public ClientDtoMapperProfile() 
    {
        CreateMap<ClientDto, Client>().ReverseMap();
    } 
}
