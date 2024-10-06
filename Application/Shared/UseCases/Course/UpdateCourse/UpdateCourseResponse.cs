using Trinode.Domain.Entities;

namespace Trinode.Application.UseCases.UpdateCourse
{
    public sealed record UpdateCourseResponse 
    {
        public Course NewCourse { get; set; }
    }
}

