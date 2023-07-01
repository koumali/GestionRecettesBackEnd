using AutoMapper;
using automotiveApi.Models;
using automotiveApi.Models.Dto;

namespace automotiveApi.Utility
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {

            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<User, UserUpdateDto>().ReverseMap();

        }
    }
}