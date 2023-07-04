using AutoMapper;
using AutomotiveApi.Models.Dto;
using AutomotiveApi.Models.Entities.Gestion;

namespace AutomotiveApi.Mapping;

public class ModeleMapping : Profile
{
    public ModeleMapping()
    {
        CreateMap<Modele, ModeleDto>();
        CreateMap<ModeleDto, Modele>();
    }
}