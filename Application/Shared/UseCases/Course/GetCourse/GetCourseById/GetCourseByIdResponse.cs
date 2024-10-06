using Trinode.Domain.Entities;

namespace Trinode.Application.UseCases.GetCourse.GetCourseById
{
    public sealed record GetCourseByIdResponse 
    {
        public Course course { get; set; }
    }
}

