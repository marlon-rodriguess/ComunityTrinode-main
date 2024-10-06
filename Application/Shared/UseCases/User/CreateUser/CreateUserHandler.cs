using AutoMapper;
using MediatR;
using Trinode.Domain.Entities;
using Trinode.Domain.Interfaces;

namespace Trinode.Application.UseCases.CreateUser
{
    public sealed class CreateUserHandler : IRequestHandler<CreateUserRequest, CreateUserResponse>
    {
        //Injecting the necessary dependencies
        private readonly IDbCommit _dbCommit;
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;

        public CreateUserHandler(IDbCommit dbCommit, IMapper mapper, IUserRepository userRepository)
        {
            _dbCommit = dbCommit;
            _mapper = mapper;
            _userRepository = userRepository;
        }
        public async Task<CreateUserResponse> Handle(CreateUserRequest request, CancellationToken cancellationToken)
        {
            var user = _mapper.Map<User>(request); //Mapeia o objeto CreateUserRequest para User
            _userRepository.Create(user); //Adiciona o usuário no banco de dados

            await _dbCommit.Commit(cancellationToken); //Aguarda salvar as alterações no banco de dados antes de retornar

            return _mapper.Map<CreateUserResponse>(user); //Mapeia o objeto User para CreateUserResponse
        }
    }
}

