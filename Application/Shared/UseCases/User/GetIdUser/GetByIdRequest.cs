using MediatR;

namespace Trinode.Application.UseCases.GetIdUser
{
    public sealed record GetByIdRequest(Guid Id) : IRequest<GetByIdResponse>{};
}
