using AutoMapper;
using MediatR;
using Trinode.Domain.Entities;
using Trinode.Domain.Interfaces;
using Trinode.Application.UseCases.Generics.Interfaces;

namespace Trinode.Application.UseCases.Generics
{
    public class UpdateGenericHandler<GenericRequest, GenericResponse, GenericEntity> : IRequestHandler<GenericRequest, GenericResponse>
        where GenericRequest : IGenericRequest, IRequest<GenericResponse>
        where GenericEntity : BaseEntity
        where GenericResponse : class
    {
        protected readonly IDbCommit _dbCommit;
        protected readonly IMapper _mapper;
        protected readonly IBaseRepository<GenericEntity> _genericRepository;

        public UpdateGenericHandler(IDbCommit dbCommit, IMapper mapper, IBaseRepository<GenericEntity> genericRepository)
        {
            _dbCommit = dbCommit;
            _mapper = mapper;
            _genericRepository = genericRepository;
        }

        public virtual async Task<GenericResponse> Handle(GenericRequest request, CancellationToken cancellationToken)
        {
        var storedEntity = await _genericRepository.GetById(request.Id, cancellationToken);
        if (storedEntity == null)
            throw new Exception("Entity not found");

        // Atualiza a entidade rastreada com os valores do request
        _mapper.Map(request, storedEntity);
        
        await _dbCommit.Commit(cancellationToken);
        return _mapper.Map<GenericResponse>(storedEntity); // Retorna a entidade atualizada
        }
    }
}

