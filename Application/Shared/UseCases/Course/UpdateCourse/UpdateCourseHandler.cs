using AutoMapper;
using Trinode.Application.UseCases.Generics;
using Trinode.Domain.Entities;
using Trinode.Domain.Interfaces;

namespace Trinode.Application.UseCases.UpdateCourse
{
    public class UpdateCourseHandler : UpdateGenericHandler<UpdateCourseRequest, UpdateCourseResponse, Course>
    {
        public UpdateCourseHandler(IDbCommit dbCommit, IMapper mapper, IBaseRepository<Course> courseRepository)
            : base(dbCommit, mapper, courseRepository){}
    }
}
