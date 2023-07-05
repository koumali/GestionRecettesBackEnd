using AutoMapper;
using AutomotiveApi.Models.Dto;
using AutomotiveApi.Models.Entities.Gestion;

namespace AutomotiveApi.Mapping;

public class VehiculeMapping : Profile
{
    public VehiculeMapping()
    {
        CreateMap<Vehicule, VehiculeDto>();
        CreateMap<VehiculeDto, Vehicule>();
    }
}