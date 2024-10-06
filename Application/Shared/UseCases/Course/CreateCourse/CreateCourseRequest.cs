using MediatR;
using Trinode.Domain.Entities;
using System.Diagnostics;

namespace Trinode.Application.UseCases
{
    public sealed record CreateCourseRequest(
        int StatusCode,
        Guid Id,
        string Name,
        string Description,
        decimal Price,
        decimal TotalHours,
        string Image,
        Category Category,
        string Technology,
        IList<Module> Modules,
        IList<Teacher> Teachers

    ) : IRequest<CreateCourseResponse>{}
}

