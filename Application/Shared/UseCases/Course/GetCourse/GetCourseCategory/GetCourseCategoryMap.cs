using AutoMapper;
using Trinode.Domain.Entities;

namespace Trinode.Application.UseCases.GetCourse
{
    public class GetCourseCategoryMap : Profile
    {
        public GetCourseCategoryMap()
        {
            CreateMap<GetCourseCategoryRequest, Course>();
            CreateMap<Course, GetCourseCategoryResponse>();
        }
    }
}
    
