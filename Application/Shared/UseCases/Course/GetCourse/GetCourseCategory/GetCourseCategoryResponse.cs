using MediatR;
using Trinode.Domain.Entities;

namespace Trinode.Application.UseCases.GetCourse
{
    public class GetCourseCategoryResponse 
    {
        public List<Course> Courses { get; set; }   
    }
}
