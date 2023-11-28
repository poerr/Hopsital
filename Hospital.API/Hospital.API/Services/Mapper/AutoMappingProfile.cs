using AutoMapper;
using Hospital.API.Models;
using Hospital.API.Services.Dto;

namespace Hospital.API.Services.Mapper
{
    public class AutoMappingProfile : Profile
    {
        public AutoMappingProfile()
        {
            CreateMap<RegisterPatientDto, Patient>();
            CreateMap<RegisterPatientDto, Address>();
            CreateMap<Patient, UserDto>();
            CreateMap<Doctor, UserDto>();
        }
    }
}
