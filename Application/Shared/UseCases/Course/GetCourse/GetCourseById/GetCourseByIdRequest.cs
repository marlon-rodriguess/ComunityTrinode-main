using MediatR;
using Trinode.Application.UseCases.Generics.Interfaces;
using Trinode.Domain.Entities;

namespace Trinode.Application.UseCases.GetCourse.GetCourseById
{
    public sealed record GetCourseByIdRequest(Course course) : IGenericRequest , IRequest<GetCourseByIdResponse>
    {
        public Guid Id { get; set; }
        public Course Course { get; set; }

        public GetCourseByIdRequest(Course course, Guid id) : this(course)
        {
            this.Course.Id = id;
            Id = id;
        }
    }
}

