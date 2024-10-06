using MediatR;
using Trinode.Domain.Entities;

namespace Trinode.Application.UseCases.GetAllUser
{
    public sealed record  GetAllUserRequest() : IRequest<IList<GetAllUserResponse>>;
}

