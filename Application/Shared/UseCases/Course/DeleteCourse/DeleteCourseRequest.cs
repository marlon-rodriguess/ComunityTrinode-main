using MediatR;
using Trinode.Application.UseCases.Generics.Interfaces;

namespace Trinode.Application.UseCases.DeleteCourse
{
    public sealed record  DeleteCourseRequest(Guid Guid) : IGenericRequest, IRequest<DeleteCourseResponse>
    {
        public Guid Id { get; set; }
    }
}

