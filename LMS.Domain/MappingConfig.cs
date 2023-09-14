using AutoMapper;
using LMS.Data.Models;
using LMS.Entities;

namespace LMS.Domain
{
    internal class MappingConfig: Profile
    {
        public MappingConfig()
        {
            // Putting a create date is gonna cause problem on update operations
            // It wouldn't help anything except create

            CreateMap<CourseModel, Courese>()
                .ForMember(dest => dest.CourseName, opt => opt.MapFrom(src => src.CourseTitle));

            CreateMap<Courese, CourseModel>()
                .ForMember(dest => dest.CourseTitle, opt => opt.MapFrom(src => src.CourseName));

            CreateMap<CourseModel, Courese>().ReverseMap();
        }
    }
}
