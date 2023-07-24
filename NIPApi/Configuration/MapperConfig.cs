using AutoMapper;
using NIPAPI.Application.DTO.Course;
using NIPAPI.Application.DTO.Registration;
using NIPAPI.Data.Data;
using NIPAPI.Domain.Model;

namespace NIPApi.Configuration
{
    public class MapperConfig: Profile
    {
        public MapperConfig()
        {
            CreateMap<Course, CreateCourseDTO>().ReverseMap();
            CreateMap<Course, GetCourseDTO>().ReverseMap();
            CreateMap<Course, UpdateCourseDTO>().ReverseMap();
            CreateMap<Registration, RegistrationDTO>().ReverseMap();
        }
    }
}
