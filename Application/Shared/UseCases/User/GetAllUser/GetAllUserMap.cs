using AutoMapper;
using Trinode.Application.UseCases.GetAllUser;
using Trinode.Domain.Entities;

namespace Trinode.Application.UseCase.GetAllUser
{
    public class GetAllUserMap : Profile
    {
        public GetAllUserMap()
        {
            CreateMap<GetAllUserRequest, User>();
            CreateMap<User, GetAllUserResponse>();
        }
    }
}

