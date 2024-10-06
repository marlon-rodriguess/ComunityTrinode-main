using AutoMapper;
using MediatR;
using Trinode.Application.UseCases.Generics;
using Trinode.Domain.Entities;
using Trinode.Domain.Interfaces;

namespace Trinode.Application.UseCases
{
    public class CreateCourseHandler : CreateGenericHandler<CreateCourseRequest, CreateCourseResponse, Course>
    {
        public CreateCourseHandler(IDbCommit dbCommit, IMapper mapper, IBaseRepository<Course> courseRepository)
            : base(dbCommit, mapper, courseRepository)
        {
        }
    }
}