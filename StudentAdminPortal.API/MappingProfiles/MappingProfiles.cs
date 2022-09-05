using AutoMapper;
using StudentAdminPortal.API.Dtos;
using StudentAdminPortal.API.Models;

namespace StudentAdminPortal.API.MappingProfiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Student, StudentDto>().ReverseMap();
            CreateMap<Gender, GenderDto>().ReverseMap();
            CreateMap<Address, AddressDto>().ReverseMap();
        }
    }
}
