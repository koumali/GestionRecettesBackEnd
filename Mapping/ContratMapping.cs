using AutoMapper;
using AutomotiveApi.Models.Dto;
using AutomotiveApi.Models.Entities.Gestion;

namespace AutomotiveApi.Mapping;

public class ContratMapping : Profile
{
    public ContratMapping()
    {
        CreateMap<ContratDto, Contrat>();
        CreateMap<Contrat, ContratDto>();
    }
}