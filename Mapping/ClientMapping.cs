using AutoMapper;
using AutomotiveApi.Models.Dto;
using AutomotiveApi.Models.Entities.Gestion;

namespace AutomotiveApi.Mapping;

public class ClientMapping : Profile
{
    public ClientMapping()
    {
        CreateMap<Client, ClientDto>();
        CreateMap<ClientDto, Client>();
    }
}