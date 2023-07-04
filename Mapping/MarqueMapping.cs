using AutoMapper;
using AutomotiveApi.Models.Dto;
using AutomotiveApi.Models.Entities.Gestion;

namespace AutomotiveApi.Mapping;

public class MarqueMapping : Profile
{
    public MarqueMapping()
    {
        CreateMap<MarqueDto, Marque>();
        CreateMap<Marque, MarqueDto>();
    }
}