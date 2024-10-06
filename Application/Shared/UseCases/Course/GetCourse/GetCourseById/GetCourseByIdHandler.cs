using AutoMapper;
using Trinode.Application.UseCases.Generics;
using Trinode.Application.UseCases.GetCourse.GetCourseById;
using Trinode.Domain.Entities;
using Trinode.Domain.Interfaces;

namespace Trinode.Application.UseCases.GetCourse.GetCourseByIdHandler
{
    public class GetCourseByIdHandler :  GetGenericByIdHandler<GetCourseByIdRequest, GetCourseByIdResponse, Course>
    {
        public GetCourseByIdHandler(IMapper mapper, IBaseRepository<Course> courseRepository) 
        : base(mapper, courseRepository){}
    }
}

