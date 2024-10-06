using AutoMapper;
using MediatR;
using Trinode.Domain.Entities;
using Trinode.Domain.Interfaces;
using System.Threading;
using System.Threading.Tasks;

namespace Trinode.Application.UseCases.Generics
{
    public class CreateGenericHandler<GenericRequest, GenericResponse, GenericEntity> : IRequestHandler<GenericRequest, GenericResponse>
        where GenericRequest : IRequest<GenericResponse>
        where GenericEntity : BaseEntity
        where GenericResponse : class
    {
        protected readonly IDbCommit _dbCommit;
        protected readonly IMapper _mapper;
        protected readonly IBaseRepository<GenericEntity> _genericRepository;

        public CreateGenericHandler(IDbCommit dbCommit, IMapper mapper, IBaseRepository<GenericEntity> genericRepository)
        {
            _dbCommit = dbCommit;
            _mapper = mapper;
            _genericRepository = genericRepository;
        }

        public virtual async Task<GenericResponse> Handle(GenericRequest request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<GenericEntity>(request);
            if (entity == null)
                throw new Exception("Entity not mapped correctly");
            else
                _genericRepository.Create(entity);

            await _dbCommit.Commit(cancellationToken);
            return _mapper.Map<GenericResponse>(entity);
        }
    }
}