using MediatR;
using Trinode.Domain.Entities;

namespace Trinode.Application.UseCases.GetCourse
{
    public class GetCourseCategoryRequest(Guid categoryid) : IRequest<GetCourseCategoryResponse>
    {
        public Guid CategoryId { get; set; }
    }
}

