using AutoMapper;
using MediatR;
using Trinode.Application.UseCases.Generics;
using Trinode.Domain.Entities;
using Trinode.Domain.Interfaces;

namespace Trinode.Application.UseCases.DeleteCourse
{
    public class DeleteCourseHandler : DeleteGenericHandler<DeleteCourseRequest, DeleteCourseResponse, Course>
    {   
         public DeleteCourseHandler(IDbCommit dbCommit, IMapper mapper, IBaseRepository<Course> courseRepository)
            : base(dbCommit, mapper, courseRepository){}
    }
}

