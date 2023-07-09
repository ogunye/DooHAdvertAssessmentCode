using AutoMapper;
using DooHAdvertAPI.Models;
using DooHAdvertAPI.Models.DTO;

namespace DooHAdvertAPI
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<CityForCreatioDto, Location>();
        }
    }
}
