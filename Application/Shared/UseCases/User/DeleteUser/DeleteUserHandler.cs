using AutoMapper;
using MediatR;
using Trinode.Domain.Interfaces;
using Trinode.Domain.Entities;

namespace Trinode.Application.UseCases.DeleteUser
{
    public class DeleteUserHandler : IRequestHandler<DeleteUserRequest, DeleteUserResponse>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        private readonly IDbCommit _dbCommit;
        public DeleteUserHandler(IUserRepository userRepository, IMapper mapper, IDbCommit IdbCommit)
        {
            _userRepository = userRepository;
            _mapper = mapper;
            _dbCommit = IdbCommit;
        }

        public async Task<DeleteUserResponse> Handle(DeleteUserRequest request, CancellationToken cancellationToken)
        {
            var user = _mapper.Map<User>(request);
            user = await  _userRepository.GetById(request.id, cancellationToken);

            if (user != null)
                _userRepository.Delete(user);
            else
                 throw new Exception("User not found");
    
            await _dbCommit.Commit(cancellationToken);
            return _mapper.Map<DeleteUserResponse>(user);
        }
    }
}

