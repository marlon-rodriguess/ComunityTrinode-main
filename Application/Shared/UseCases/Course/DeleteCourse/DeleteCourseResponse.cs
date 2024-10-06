using MediatR;
using Trinode.Domain.Entities;
using System.Diagnostics;

namespace Trinode.Application.UseCases.DeleteCourse
{
    public class DeleteCourseResponse : BaseEntity, IRequest<DeleteCourseResponse>
    { public Guid? Id { get; set; } ActivityStatusCode StatusCode {get; set;}}
}

