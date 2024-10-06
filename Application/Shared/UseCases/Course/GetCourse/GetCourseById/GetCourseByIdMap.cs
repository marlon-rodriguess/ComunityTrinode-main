using AutoMapper;
using FluentValidation;

namespace Trinode.Application.UseCases.GetCourse.GetCourseById
{
    public class GetCourseByIdMap : Profile
    {
        public GetCourseByIdMap()
        {
            CreateMap<GetCourseByIdRequest, Domain.Entities.Course>();
            CreateMap<Domain.Entities.Course, GetCourseByIdResponse>();
        }
    }

}

