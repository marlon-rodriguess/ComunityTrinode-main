using AutoMapper;
using MediatR;
using Trinode.Domain.Entities;
using Trinode.Domain.Interfaces;

namespace Trinode.Application.UseCases.UpdateUser
{
    public class UpdateUserHandler : IRequestHandler<UpdateUserRequest, UpdateUserResponse>
    {
        private readonly IUserRepository _userRepository;
        private readonly IDbCommit _dbCommit;
        private readonly IMapper _mapper;
        public UpdateUserHandler(IUserRepository userRepository, IDbCommit dbCommit, IMapper mapper)
        {
            _userRepository = userRepository;
            _dbCommit = dbCommit;
            _mapper = mapper;
        }

        public async Task<UpdateUserResponse> Handle(UpdateUserRequest request, CancellationToken cancellationToken)
        {
            var user = _mapper.Map<User>(request);
            user = await _userRepository.GetById(request.id,cancellationToken);

            if (user != null)
            {
                user.Name = request.Name;
                user.Email = request.Email;
                _userRepository.Update(user);
                await _dbCommit.Commit(cancellationToken);
            }              
            else{throw new Exception("User not found");}
            return _mapper.Map<UpdateUserResponse>(user);
        }
    }
}

