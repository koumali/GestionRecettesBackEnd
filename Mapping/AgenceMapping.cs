using AutoMapper;
using AutomotiveApi.Models.Dto;
using AutomotiveApi.Models.Entities.Gestion;

namespace AutomotiveApi.Mapping;

public class AgenceMapping : Profile
{
    public AgenceMapping()
    {
        CreateMap<Agence, AgenceDto>();
        CreateMap<AgenceDto, Agence>();
    }
}