using MediatR;
using Trinode.Application.UseCases.Generics.Interfaces;
using Trinode.Domain.Entities;

namespace Trinode.Application.UseCases.UpdateCourse
{
    public sealed record UpdateCourseRequest(Course NewCourse) : IGenericRequest, IRequest<UpdateCourseResponse>
    {
        public Guid Id { get; set; }
        public UpdateCourseRequest(Course newCourse, Guid id) : this(newCourse)
        {
            NewCourse.Id = id; // Atribui o id fornecido diretamente ao Id de NewCourse
            Id = id; // Atribui o id fornecido ao Id da requisição
        }
    }
}