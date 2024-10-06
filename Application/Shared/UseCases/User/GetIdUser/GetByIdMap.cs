using AutoMapper;
using Trinode.Domain.Entities;

namespace Trinode.Application.UseCases.GetIdUser
{
    public class GetByIdMap : Profile
    {
        public GetByIdMap()
        {
            CreateMap<GetByIdRequest, User>();
            CreateMap<User, GetByIdResponse>();
        }
    }
}

