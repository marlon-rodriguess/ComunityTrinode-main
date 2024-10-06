using AutoMapper;
using MediatR;
using Trinode.Application.UseCases.Generics.Interfaces;
using Trinode.Domain.Entities;
using Trinode.Domain.Interfaces;

namespace Trinode.Application.UseCases.Generics
{
    public class DeleteGenericHandler<GenericRequest, GenericResponse, GenericEntity> : IRequestHandler<GenericRequest, GenericResponse>
        where GenericRequest : IGenericRequest, IRequest<GenericResponse>
        where GenericEntity : BaseEntity
        where GenericResponse : class
        {
            protected readonly IDbCommit _dbCommit;
            protected readonly IMapper _mapper;
            protected readonly IBaseRepository<GenericEntity> _genericRepository;

            public DeleteGenericHandler(IDbCommit dbCommit, IMapper mapper, IBaseRepository<GenericEntity> genericRepository)
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
                    _genericRepository.Delete(entity);

                await _dbCommit.Commit(cancellationToken);
                return _mapper.Map<GenericResponse>(entity);
            }
        }
}

