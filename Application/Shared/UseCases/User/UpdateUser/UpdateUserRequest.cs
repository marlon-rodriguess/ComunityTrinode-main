using MediatR;

namespace Trinode.Application.UseCases.UpdateUser
{
    public sealed record UpdateUserRequest(Guid id, string Name, string Email) : IRequest<UpdateUserResponse>{}
}

