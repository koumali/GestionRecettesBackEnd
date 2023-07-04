using AutoMapper;
using AutomotiveApi.Models.Dto;
using AutomotiveApi.Models.Entities.Gestion;

namespace AutomotiveApi.Mapping;

public class OffreMapping : Profile
{
    public OffreMapping()
    {
        CreateMap<Offre, OffreDto>();
        CreateMap<OffreDto, Offre>();
    }
}