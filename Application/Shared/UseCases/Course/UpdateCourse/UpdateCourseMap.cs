using AutoMapper;

namespace Trinode.Application.UseCases.UpdateCourse
{
    public class UpdateCourseMap : Profile
    {
        public UpdateCourseMap()
        {
            CreateMap<UpdateCourseRequest, Domain.Entities.Course>();
            CreateMap<Domain.Entities.Course, UpdateCourseResponse>();
        }
    }
}

