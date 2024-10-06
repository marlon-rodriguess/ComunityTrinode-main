using AutoMapper;

namespace Trinode.Application.UseCases.DeleteCourse
{    
    public class DeleteCourseMap : Profile 
    {
        public DeleteCourseMap()
        {
            CreateMap<DeleteCourseRequest, Domain.Entities.Course>();
            CreateMap<Domain.Entities.Course, DeleteCourseResponse>();
        }
    }
}

