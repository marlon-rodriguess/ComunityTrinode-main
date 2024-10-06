using MediatR;
using Trinode.Application.UseCases.DeleteUser;

namespace Trinode.Application.UseCases.DeleteUser
{
    public sealed record DeleteUserRequest(Guid id) : IRequest<DeleteUserResponse>{}
}

