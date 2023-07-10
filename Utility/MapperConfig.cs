using AutoMapper;
using AutomotiveApi.Models.Dto;
using AutomotiveApi.Models.Entities.Gestion;
using AutomotiveApi.Models.Entities.Param;

namespace AutomotiveApi.Utility
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<User, UserUpdateDto>().ReverseMap();
            CreateMap<Vehicule, VehiculeDto>().ReverseMap();
            CreateMap<Client, ClientDto>().ReverseMap();
            CreateMap<Marque, MarqueDto>().ReverseMap();
            CreateMap<Modele, ModeleDto>().ReverseMap();
            CreateMap<Agence, AgenceDto>().ReverseMap();
            CreateMap<Offre, OffreDto>().ReverseMap();            
            CreateMap<Contrat, ContratDto>().ReverseMap();


        }
    }
}