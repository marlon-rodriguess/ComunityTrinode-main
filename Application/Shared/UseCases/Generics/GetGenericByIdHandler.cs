using AutoMapper;
using MediatR;
using Trinode.Application.UseCases.Generics.Interfaces;
using Trinode.Domain.Entities;
using Trinode.Domain.Interfaces;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Trinode.Application.UseCases.Generics
{
    public class GetGenericByIdHandler<GenericRequest, GenericResponse, GenericEntity> : IRequestHandler<GenericRequest, GenericResponse>
        where GenericRequest : IGenericRequest, IRequest<GenericResponse>
        where GenericEntity : BaseEntity
        where GenericResponse : class
    {
        private readonly IMapper _mapper;
        private readonly IBaseRepository<GenericEntity> _genericRepository;

        public GetGenericByIdHandler(IMapper mapper, IBaseRepository<GenericEntity> genericRepository)
        {
            _mapper = mapper;
            _genericRepository = genericRepository;
        }

        public async Task<GenericResponse> Handle(GenericRequest request, CancellationToken cancellationToken)
        {
            var entity = await _genericRepository.GetById(request.Id, cancellationToken);
            if (entity == null)
                throw new Exception("Entity not found");

            return _mapper.Map<GenericResponse>(entity);
        }
    }
}