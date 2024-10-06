using AutoMapper;
using MediatR;
using Trinode.Domain.Interfaces;

namespace Trinode.Application.UseCases.GetAllUser
{
    public class GetAllUserHandler : IRequestHandler<GetAllUserRequest, IList<GetAllUserResponse>>
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;

        public GetAllUserHandler(IDbCommit dbCommit, IMapper mapper, IUserRepository userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }
        public async Task<IList<GetAllUserResponse>> Handle(GetAllUserRequest request, CancellationToken cancellationToken)
        {
            return _mapper.Map<IList<GetAllUserResponse>>(await _userRepository.GetAll(cancellationToken));
        }
    }
}

