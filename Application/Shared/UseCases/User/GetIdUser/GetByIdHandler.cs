using AutoMapper;
using MediatR;
using Trinode.Domain.Entities;
using Trinode.Domain.Interfaces;

namespace Trinode.Application.UseCases.GetIdUser
{
    public sealed class GetByIdHandler : IRequestHandler<GetByIdRequest, GetByIdResponse>
    {
        //Injecting the necessary dependencies
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;

        public GetByIdHandler(IMapper mapper, IUserRepository userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }
        public async Task<GetByIdResponse> Handle(GetByIdRequest request, CancellationToken cancellationToken)
        {
            var user = _mapper.Map<User>(request); //Realizo o mapeammento do GetByIdRequest para User
            user = await _userRepository.GetById(user.Id, cancellationToken); //Busco o usuário no banco de dados
            return _mapper.Map<GetByIdResponse>(user); //Realizo de volta o mapeamento do User para GetByIdResponse
        }
    }
}

