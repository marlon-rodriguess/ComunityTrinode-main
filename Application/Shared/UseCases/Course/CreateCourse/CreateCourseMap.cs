using AutoMapper;
using Trinode.Domain.Entities;

namespace Trinode.Application.UseCases
{
    public class CourseMap : Profile
    {
        public CourseMap()
        {
            CreateMap<CreateCourseRequest, Course>();
            CreateMap<Course, CreateCourseResponse>();
        }
    }
}

