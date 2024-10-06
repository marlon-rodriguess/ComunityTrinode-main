using MediatR;

namespace Trinode.Application.UseCases.CreateUser
{
    public sealed record CreateUserRequest(string Email, string Name, string Password) : IRequest<CreateUserResponse>{}  
}